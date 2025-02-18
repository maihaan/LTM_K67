using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net;
using System.Net.Sockets;

namespace UdpServer
{
    class Program // TCP UDP
    {
        static void Main(string[] args)
        {
            String serverIP = "127.0.0.1";
            int serverPort = 8555;
            IPEndPoint ep = new IPEndPoint(IPAddress.Parse(serverIP), serverPort);
            UdpClient udp = new UdpClient(serverPort);
            while (true)
            {                
                if (udp.Available > 0)
                {
                    byte[] duLieuNhan = udp.Receive(ref ep);
                    Console.WriteLine(DateTime.Now.ToString() + ": " + Encoding.UTF8.GetString(duLieuNhan));
                }
            }    
        }
    }
}
