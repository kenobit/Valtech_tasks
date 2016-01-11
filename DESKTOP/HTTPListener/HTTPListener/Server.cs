using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace HTTPListener
{
    class Server
    {
        TcpListener Listener;

        public Server(int port)
        {
            Listener = new TcpListener(IPAddress.Any, port);
            Listener.Start();
            Console.WriteLine("server started");

            while (true)
            {
                Client c = new Client(Listener.AcceptTcpClient());
            }
        }

        ~Server()
        {
            if (Listener != null)
            {
                Listener.Stop();
            }
        }

        static void Main(string[] args)
        {
            Server srw = new Server(645);

        }
    }
}
