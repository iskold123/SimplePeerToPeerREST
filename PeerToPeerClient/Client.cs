using System.IO;
using System.Net.Sockets;

namespace PeerToPeerClient
{
    internal class Client
    {
        public void Start()
        {
            TcpClient socket = new TcpClient("",4001);

            StreamReader sr = new StreamReader(socket.GetStream());
            StreamWriter sw = new StreamWriter(socket.GetStream());


        }
    }
}