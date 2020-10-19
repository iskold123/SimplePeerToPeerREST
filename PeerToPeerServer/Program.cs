using System;

namespace PeerToPeerServer
{
    class Program
    {
        static void Main(string[] args)
        {
            Server worker = new Server();
            worker.Start();

            Console.ReadLine();
        }
    }
}
