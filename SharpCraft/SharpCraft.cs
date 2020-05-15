using System;
using System.Net;
using SharpCraft.Interfaces;
using SharpCraft.Network;

namespace SharpCraft
{
    /// <summary>
    /// Launch class of SharpCraft.
    /// </summary>
    public class SharpCraft : IHostBuilder
    {
        #region Global
        public static readonly string ServerName = "SharpCraft";
        public static readonly string Author = "AmemiyaShigure";
        public static readonly string Version = "1.0.0";
        #endregion
        
        private IHost Host { get; }
        
        private SharpCraft()
        {
            Host = new ServerHost();
        }
        
        // I don't know why do this, but seems cool!
        public static IHostBuilder Create(string[] args)
        {
            return new SharpCraft();
        }

        public IHostBuilder Bind(IPAddress ip, int port)
        {
            Host.Bind(ip, port);
            return this;
        }
        
        public void Run()
        {
            Host.Listen(256);
        }
    }
}
