using System;
using System.Text;
using System.Net.Sockets;

namespace ConsoleChatServer
{
    public class ClientObject
    {
        protected internal string Id { get; private set; }
        protected internal NetworkStream Stream { get; private set; }
        string userName;
        TcpClient client;
        ServerObject server;

        public ClientObject(TcpClient tcpClient, ServerObject serverObject)
        {
            Id = Guid.NewGuid().ToString();
            client = tcpClient;
            server = serverObject;
            serverObject.AddConnection(this);
        }
        public void Process()
        {
            try
            {
                Stream = client.GetStream();
                string message = GetMessage();
                userName = message;

                message = userName + " enter in chat";
                server.BroadcastMessage(message, this.Id);
                Console.WriteLine(message);
                bool flag = true;
                while (flag)
                {
                    try
                    {
                        message = GetMessage();
                        message = String.Format("{0}: {1}", userName, message);
                        
                        if (message.Contains("/e") || message.Contains("/E"))
                        {
                            message = String.Format("{0}: left chat", userName);
                            Console.WriteLine(message);
                            server.RemoveConnection(this.Id);
                            flag = false;
                        }
                        else {
                            if (flag)
                            {
                                Console.WriteLine(message);
                                server.BroadcastMessage(message, this.Id);

                            }
                        }
                    }
                    catch
                    {
                        message = String.Format("{0}: left chat", userName);
                        Console.WriteLine(message);
                        server.BroadcastMessage(message, this.Id);
                        break;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                server.RemoveConnection(this.Id);
                Close();
            }
        }

        private string GetMessage()
        {
            byte[] data = new byte[64]; 
            StringBuilder builder = new StringBuilder();
            int bytes = 0;
            do
            {
                bytes = Stream.Read(data, 0, data.Length);
                builder.Append(Encoding.Unicode.GetString(data, 0, bytes));
            }
            while (Stream.DataAvailable);

           
            return builder.ToString();
        }

        protected internal void Close()
        {
            if (Stream != null)
                Stream.Close();
            if (client != null)
                client.Close();
        }
    }
}
