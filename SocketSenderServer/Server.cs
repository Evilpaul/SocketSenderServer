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

		public Server(IProgress<string> prg_str, IProgress<Boolean> prg_hmi)
		{
			progress_str = prg_str;
			progress_hmi = prg_hmi;
		}

		public void openSocket(int port)
		{

		}

		public void sendMessage(string msg)
		{

		}

		public void closeSocket()
		{

		}

		private class SocketPacket
		{
			public Socket thisSocket;
			public byte[] dataBuffer = new byte[1];
		}
	}
}
