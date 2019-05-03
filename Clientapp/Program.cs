using System;
using System.Net;
using System.Net.Sockets;
using System.Text;



namespace Clientapp
{
    class Program
    {
        static void Main(string[] args)
        {
            string IP = "127.0.0.1";
            string command = "GET";
            const int MAXBUFF = 9999;
           const string operand = "index.html";
            const int PORT = 8080;

            var client = new TcpClient();
            Console.WriteLine($"Client attempting to connect to {IP}");
            client.Connect(IP, PORT);
            var stream = client.GetStream();
            string s = command + " " + operand + " HTTP/1.1\n";
            stream.Write(Encoding.ASCII.GetBytes(s, 0, s.Length), 0, s.Length);
            byte[] Buffer = new byte[MAXBUFF];
            int iLen = stream.Read(Buffer, 0, MAXBUFF);

            
            
            

          
        }
    }
}
