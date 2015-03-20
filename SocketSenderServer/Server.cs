using System;
using System.Linq;
using System.Net;
using System.Net.Sockets;

namespace SocketSenderServer
{
	class Server
	{
		private IProgress<string> progress_str;
		private IProgress<Boolean> progress_hmi;

		private const int MAX_CLIENTS = 10;

		private AsyncCallback pfnWorkerCallBack;
		private Socket m_mainSocket;
		private Socket[] m_workerSocket = new Socket[10];
		private int m_clientCount = 0;

		public Server(IProgress<string> prg_str, IProgress<Boolean> prg_hmi)
		{
			progress_str = prg_str;
			progress_hmi = prg_hmi;
		}

		public void openServer(int port)
		{
			try
			{
				// Create the listening socket...
				m_mainSocket = new Socket(AddressFamily.InterNetwork,
										  SocketType.Dgram,
										  ProtocolType.Udp);
				IPEndPoint ipLocal = new IPEndPoint(IPAddress.Any, port);
				// Bind to local IP Address...
				m_mainSocket.Bind(ipLocal);
				// Start listening...
				//SocketAsyncEventArgs socArgs = new SocketAsyncEventArgs();
				//m_mainSocket.ReceiveFromAsync(socArgs);
				// Create the call back for any client connections...
				//m_mainSocket.BeginAccept(new AsyncCallback(OnClientConnect), null);
				EndPoint tempRemoteEP = (EndPoint)ipLocal;
//				StateObject so2 = new StateObject();
//				so2.workSocket = m_mainSocket;
//				m_mainSocket.BeginReceiveFrom(so2.buffer, 0, StateObject.BUFFER_SIZE, 0, ref tempRemoteEP,
//									   new AsyncCallback(OnClientConnect), null);

				progress_hmi.Report(true);
			}
			catch (SocketException se)
			{
				progress_str.Report(se.Message);
				progress_hmi.Report(false);
			}
		}

		public void sendMessage(string msg)
		{
			try
			{
				Object objData = msg;
				byte[] byData = StringToByteArray(objData.ToString());
				progress_str.Report(msg);
				for (int i = 0; i < m_clientCount; i++)
				{
					if (m_workerSocket[i] != null)
					{
						if (m_workerSocket[i].Connected)
						{
							m_workerSocket[i].Send(byData);
						}
					}
				}
			}
			catch (SocketException se)
			{
				progress_str.Report(se.Message);
			}
		}

		public void closeServer()
		{
			CloseSockets();
		}

		private static byte[] StringToByteArray(string hex)
		{
			return Enumerable.Range(0, hex.Length)
							 .Where(x => x % 2 == 0)
							 .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
							 .ToArray();
		}

		// This is the call back function, which will be invoked when a client is connected
		private void OnClientConnect(IAsyncResult asyn)
		{
			try
			{
				// Here we complete/end the BeginAccept() asynchronous call
				// by calling EndAccept() - which returns the reference to
				// a new Socket object
				m_workerSocket[m_clientCount] = m_mainSocket.EndAccept(asyn);
				// Let the worker Socket do the further processing for the 
				// just connected client
				WaitForData(m_workerSocket[m_clientCount]);
				// Now increment the client count
				++m_clientCount;
				// Display this client connection as a status message on the GUI	
				String str = String.Format("Client # {0} connected", m_clientCount);
				progress_str.Report(str);

				// Since the main Socket is now free, it can go back and wait for
				// other clients who are attempting to connect
				m_mainSocket.BeginAccept(new AsyncCallback(OnClientConnect), null);
			}
			catch (ObjectDisposedException)
			{
				progress_str.Report("OnClientConnection: Socket has been closed");
			}
			catch (SocketException se)
			{
				progress_str.Report(se.Message);
				progress_hmi.Report(false);
			}

		}

		// Start waiting for data from the client
		public void WaitForData(System.Net.Sockets.Socket soc)
		{
			try
			{
				if (pfnWorkerCallBack == null)
				{
					// Specify the call back function which is to be 
					// invoked when there is any write activity by the 
					// connected client
					pfnWorkerCallBack = new AsyncCallback(OnDataReceived);
				}
				SocketPacket theSocPkt = new SocketPacket();
				theSocPkt.m_currentSocket = soc;
				// Start receiving any data written by the connected client
				// asynchronously
				soc.BeginReceive(theSocPkt.dataBuffer, 0,
								   theSocPkt.dataBuffer.Length,
								   SocketFlags.None,
								   pfnWorkerCallBack,
								   theSocPkt);
			}
			catch (SocketException se)
			{
				progress_str.Report(se.Message);
				progress_hmi.Report(false);
			}
		}

		// This the call back function which will be invoked when the socket
		// detects any client writing of data on the stream
		public void OnDataReceived(IAsyncResult asyn)
		{
			try
			{
				SocketPacket socketData = (SocketPacket)asyn.AsyncState;

				int iRx = 0;
				// Complete the BeginReceive() asynchronous call by EndReceive() method
				// which will return the number of characters written to the stream 
				// by the client
				iRx = socketData.m_currentSocket.EndReceive(asyn);
				char[] chars = new char[iRx + 1];
				System.Text.Decoder d = System.Text.Encoding.UTF8.GetDecoder();
				int charLen = d.GetChars(socketData.dataBuffer,
										 0, iRx, chars, 0);
				string szData = new System.String(chars);
				progress_str.Report(szData);

				// Continue the waiting for data on the Socket
				WaitForData(socketData.m_currentSocket);
			}
			catch (ObjectDisposedException)
			{
				progress_str.Report("OnDataReceived: Socket has been closed");
			}
			catch (SocketException se)
			{
				progress_str.Report(se.Message);
				progress_hmi.Report(false);
			}
		}

		private class SocketPacket
		{
			public System.Net.Sockets.Socket m_currentSocket;
			public byte[] dataBuffer = new byte[1];
		}

		private void CloseSockets()
		{
			if (m_mainSocket != null)
			{
				m_mainSocket.Close();
			}
			for (int i = 0; i < m_clientCount; i++)
			{
				if (m_workerSocket[i] != null)
				{
					m_workerSocket[i].Close();
					m_workerSocket[i] = null;
				}
			}
		}
	}
}
