using System.Net;
using System.Net.Sockets;
using SharpCraft.Events.Monitors;

namespace SharpCraft.Network
{
    /// <summary>
    /// Default implement of IHost.
    /// </summary>
    public class ServerHost : IHost
    {
        public IPAddress Ip { get; private set; }
        public int Port { get; private set; }
        
        private readonly Socket Socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        public static readonly SocketMonitor Monitor = new SocketMonitor();

        public void Bind(IPAddress ip, int port)
        {
            Ip = ip;
            Port = port;
            
            Socket.Bind(new IPEndPoint(ip, port));
        }

        public void Listen(int queueLength)
        {
            Socket.Listen(queueLength);
            
            var e = new SocketAsyncEventArgs();
            e.Completed += OnCompleted;
            var result = Socket.AcceptAsync(e);
        }

        private void OnCompleted(object sender, SocketAsyncEventArgs e)
        {
            if (e.LastOperation == SocketAsyncOperation.Accept)
            {
                var socket = e.AcceptSocket;
                if (socket != null)
                {
                    // Hi, let monitor do something.
                    Monitor.SocketConnected(socket);
                }
            }

            e.AcceptSocket = null;
            Socket.AcceptAsync(e);
        }
    }
}
