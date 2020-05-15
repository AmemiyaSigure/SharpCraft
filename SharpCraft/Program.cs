using System;
using System.Net;

namespace SharpCraft
{
    class Program
    {
        static void Main(string[] args)
        {
            SharpCraft.Create(args)
                .Bind(IPAddress.Any, 25565)
                .Run();
        }
    }
}
