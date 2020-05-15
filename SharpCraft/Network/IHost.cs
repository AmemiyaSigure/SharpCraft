using System.Net;

namespace SharpCraft.Network
{
    /// <summary>
    /// Interface of Server Host.
    /// </summary>
    public interface IHost
    {
        public void Bind(IPAddress ip, int port);

        public void Listen(int queueLength);
    }
}