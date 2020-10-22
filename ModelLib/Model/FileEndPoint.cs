using System;
using System.Collections.Generic;
using System.Text;

namespace ModelLib.Model
{
    public class FileEndPoint
    {
        private string _ipAddress;
        private int _portNumber;

        public FileEndPoint()
        {

        }

        public FileEndPoint(string ipAddress, int portNumber)
        {
            _ipAddress = ipAddress;
            _portNumber = portNumber;
        }

        public string IpAddress
        {
            get => _ipAddress;
            set => _ipAddress = value;
        }

        public int PortNumber
        {
            get => _portNumber;
            set => _portNumber = value;
        }

        public override string ToString()
        {
            return $"{nameof(IpAddress)}: {IpAddress}, {nameof(PortNumber)}: {PortNumber}";
        }
    }
}
