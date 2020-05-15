using System;
using System.Net.Sockets;
using SharpCraft.Enumerates;

namespace SharpCraft.Events.Args
{
    public class SocketConnectedEventArgs : EventArgs
    {
        public Socket Client { get; }
        public ClientStat Stat { get; }
        
        public SocketConnectedEventArgs(Socket socket, ClientStat stat)
        {
            Client = socket;
            Stat = stat;
        }
    }
}