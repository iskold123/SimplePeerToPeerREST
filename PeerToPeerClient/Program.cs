using System;

namespace PeerToPeerClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Client worker = new Client();
            worker.Start();

            Console.ReadLine();
        }
    }
}
