using System.Diagnostics.CodeAnalysis;
using System.Net.Sockets;
using SharpCraft.Enumerates;
using SharpCraft.Events.Args;

namespace SharpCraft.Events.Monitors
{
    public class SocketMonitor
    {
        public delegate void SocketConnectedHandler(object sender, SocketConnectedEventArgs e);

        public event SocketConnectedHandler OnSocketConnected;

        public void SocketConnected(Socket socket)
        {
            OnSocketConnected(this, new SocketConnectedEventArgs(socket, ClientStat.Connected));
        }
    }
}