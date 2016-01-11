using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;


namespace HTTPListener
{
    public class Client
    {
        public Client(TcpClient client)
        {
            //string path = "home/index.html";
            string errors = @"errors\";


            string Request = "";
            byte[] Buffer = new byte[1024];
            int Count;
            while ((Count = client.GetStream().Read(Buffer, 0, Buffer.Length)) > 0)
            {
                Request += Encoding.ASCII.GetString(Buffer, 0, Count);
                if (Request.IndexOf("\r\n\r\n") >= 0 || Request.Length > 4096)
                {
                    break;
                }
            }

            Match ReqMatch = Regex.Match(Request, @"^\w+\s+([^\s\?]+)[^\s]*\s+HTTP/.*|");
            string RequestUri = ReqMatch.Groups[1].Value;
            RequestUri = Uri.UnescapeDataString(RequestUri);

            //ParseField(RequestUri);
            try {
                if (RequestUri.Equals("/"))
                {
                    RequestUri = "home/index.html";
                }
                else
                {
                    RequestUri = RequestUri.Substring(1);
                }

                string html = new StreamReader(RequestUri).ReadToEnd(); // "<!DOCTYPE html><html><body><h1 style=\'color:red;text-aligment:center\'>Hello world!</h1></body></html>";
                string str = "HTTP/1.1 200 OK\nContent-type: text/html\nContent-Length:" + html.Length.ToString() + "\n\n" + html;
                byte[] buffer = Encoding.ASCII.GetBytes(str);
                client.GetStream().Write(buffer, 0, buffer.Length);
            }
            catch
            {
                string html = new StreamReader(errors+"404.html").ReadToEnd();
                string str = "HTTP/1.1 200 OK\nContent-type: text/html\nContent-Length:" + html.Length.ToString() + "\n\n" + html;
                byte[] buffer = Encoding.ASCII.GetBytes(str);
                client.GetStream().Write(buffer, 0, buffer.Length);
            }
            
            Console.WriteLine("Client started");
            client.Close();
        }

        string ParseField(string address)
        {
            Console.WriteLine("Address - {0}",address);

            string controller = address.Contains(@"home\") || address.Contains(@"home\") || address.Contains(@"home/") || address.Contains(@"home/") ? "home" : address.Contains(@"job\") || address.Contains(@"Job\") || address.Contains(@"job/") || address.Contains(@"Job/") ? "job" : "404";

            switch (controller)
            {
                case "home":
                    {
                        Console.WriteLine("Controller - {0}",controller);
                    }
                    break;
                case "job":
                    {
                        Console.WriteLine("Controller - {0}", controller);

                    }
                    break;
                case "404":
                    {
                        Console.WriteLine("Controller - {0}", controller);
                    }
                    break;

                default:
                    {
                        Console.WriteLine("Controller - {0}", controller);
                    }
                    break;
            }

            return address;
        }


    }
}
