using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;

namespace PeerToPeerServer
{
    public class Server
    {
        public void Start()
        {
            TcpListener server = new TcpListener(IPAddress.Loopback, 4000);

            server.Start();

            while (true)
            {
                TcpClient socket = server.AcceptTcpClient();
                Task.Run(() =>
                {
                    TcpClient tempSocket = socket;
                    DoClient(tempSocket);
                });
            }
        }

        private void DoClient(TcpClient socket)
        {
            StreamReader sr = new StreamReader(socket.GetStream());
            StreamWriter sw = new StreamWriter(socket.GetStream());

            var str = sr.ReadLine();
            string str2;

            if (str == "GetAll")
            {
                sw.WriteLine($"Filer tilgængelige;");
                Console.WriteLine($"Filer i listen: ");

                foreach (var FilEndPoint in _data) sw.WriteLine(JsonConverter.SerializeObjekt(_data));
                foreach (var VARIABLE in COLLECTION)
                {
                    Console.WriteLine(_data);
                }

            }

            sw.Flush();

            socket.Close();
        }
    }
}