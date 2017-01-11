﻿using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ITnmg.IOCPSocket
{
	/// <summary>
	/// Socket服务端
	/// </summary>
	public class SocketServerManager : SocketManagerBase
	{
		/// <summary>
		/// 监听用的 socket
		/// </summary>
		protected Socket listenSocket;

		/// <summary>
		/// 服务端运行状态变化事件
		/// </summary>
		public event EventHandler<bool> ServerStatusChangeEvent;



		/// <summary>
		/// 创建服务端实例
		/// </summary>
		public SocketServerManager()
		{
		}



		/// <summary>
		/// 开始监听连接
		/// </summary>
		/// <param name="domainOrIP">要监听的域名或IP</param>
		/// <param name="port">端口</param>
		/// <param name="preferredIPv4">如果用域名初始化,可能返回多个ipv4和ipv6地址,指定是否首选ipv4地址.</param>
		/// <param name="listenQueue">用于监听的 socket 等待队列</param>
		/// <returns>返回实际监听的 EndPoint</returns>
		public virtual async Task<IPEndPoint> StartAsync( string domainOrIP, int port, bool preferredIPv4 = true, int listenQueue = 200 )
		{
			IPEndPoint result = null;

			try
			{
				if ( this.listenSocket == null )
				{
					result = await GetIPEndPoint( domainOrIP, port, preferredIPv4 );
					this.listenSocket = new Socket( result.AddressFamily, SocketType.Stream, ProtocolType.Tcp );
					this.listenSocket.SendTimeout = this.sendTimeOut;
					this.listenSocket.ReceiveTimeout = this.receiveTimeOut;
					this.listenSocket.SendBufferSize = this.singleBufferMaxSize;
					this.listenSocket.ReceiveBufferSize = this.singleBufferMaxSize;
					this.listenSocket.Bind( result );
					this.listenSocket.Listen( listenQueue );

					SocketAsyncEventArgs args = new SocketAsyncEventArgs();
					args.SetBuffer( new byte[this.singleBufferMaxSize], 0, this.singleBufferMaxSize );
					args.DisconnectReuseSocket = true;
					args.Completed += AcceptArgs_Completed;

					if ( !this.listenSocket.AcceptAsync( args ) )
					{
						AcceptArgs_Completed( this.listenSocket, args );
					}

					OnServerStateChange( this, true );
				}
				else
				{
					result = this.listenSocket.LocalEndPoint as IPEndPoint;
					OnError( this, new Exception( "服务端已在运行" ) );
				}
			}
			catch ( Exception ex )
			{
				await this.StopAsync();
				this.OnError( this, ex );
			}

			return result;
		}

		/// <summary>
		/// 关闭监听
		/// </summary>
		public virtual async Task StopAsync()
		{
			if ( this.listenSocket != null )
			{
				try
				{
					await CloseConnectList();
					CloseSocket( this.listenSocket );
					OnServerStateChange( this, false );
				}
				catch ( Exception ex )
				{
					OnError( this, ex );
				}
				finally
				{
					this.listenSocket = null;
				}
			}
		}


		/// <summary>
		/// 监听 socket 接收到新连接
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected virtual void AcceptArgs_Completed( object sender, SocketAsyncEventArgs e )
		{
			if ( e.SocketError == SocketError.Success )
			{
				//等待3秒,如果有空余资源,接收连接,否则断开socket.
				if ( semaphore.WaitOne( 3000 ) )
				{
					var result = GetUserToken();
					result.CurrentSocket = e.AcceptSocket;
					result.Id = (int)e.AcceptSocket.Handle;
					result.ReceiveArgs.UserToken = result;
					result.SendArgs.UserToken = result;

					if ( connectedEntityList.TryAdd( result.Id, result ) )
					{
						if ( !result.CurrentSocket.ReceiveAsync( result.ReceiveArgs ) )
						{
							SendAndReceiveArgs_Completed( this, result.ReceiveArgs );
						}

						if ( !result.CurrentSocket.SendAsync( result.SendArgs ) )
						{
							SendAndReceiveArgs_Completed( this, result.SendArgs );
						}

						//SocketError.Success 状态回传null, 表示没有异常
						OnConnectedStatusChange( this, result.Id, true, null );
					}
					else
					{
						FreeUserToken( result );
						semaphore.Release();
					}
				}
				else
				{
					CloseSocket( e.AcceptSocket );
				}

				//e.UserToken = ToConnCompletedSuccess( e.AcceptSocket );
			}
			else
			{
				ToConnCompletedError( e.AcceptSocket, e.SocketError, e.UserToken as SocketUserToken );
			}

			//监听下一个请求
			e.AcceptSocket = null;
			e.UserToken = null;

			if ( e.SocketError != SocketError.OperationAborted && this.listenSocket != null && !this.listenSocket.AcceptAsync( e ) )
			{
				AcceptArgs_Completed( this.listenSocket, e );
			}
		}

		/// <summary>
		/// 引发 ServerStateChange 事件
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		protected virtual void OnServerStateChange( object sender, bool e )
		{
			if ( ServerStatusChangeEvent != null )
			{
				ServerStatusChangeEvent( sender, e );
			}
		}
	}
}
