using System.Net;
using SharpCraft.Network;

namespace SharpCraft.Interfaces
{
    public interface IHostBuilder
    {
        public IHostBuilder Bind(IPAddress ip, int port);

        public void Run();
    }
}