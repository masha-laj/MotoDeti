using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotoDeti
{
    public class UDPSocketMessageReceivedEventArgs : EventArgs
    {
        public IPEndPoint Endpoint { get; set; }
        public string Message { get; set; }
    }
    public class UDPSocket
    {
        private bool destroyed = false;
        private bool alive = true;
        TcpListener listener;
        private UdpClient socket;
        private IPAddress groupAddress;
        private int ttl = 20;
        private Task task;

        private string host;
        private int port;

        public event EventHandler<UDPSocketMessageReceivedEventArgs> MessageReceived;

        public UDPSocket(string host, int port)
        {
            this.host = host;
            this.port = port;

            try
            {
                listener = new TcpListener(IPAddress.Any, port);
                listener.Start();

                task = new Task(AcceptClients);
                task.Start();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void AcceptClients()
        {
            while (!destroyed)
            {
                TcpClient client = listener.AcceptTcpClient();
                Console.WriteLine("Accept: " + client.Client.RemoteEndPoint.ToString());
                ClientObject clientObject = new ClientObject(client);
                clientObject.MessageReceived += ReceiveMessages;
                Thread clientThread = new Thread(new ThreadStart(clientObject.Process));
                clientThread.Start();
            }
        }


        private void ReceiveMessages(object sender, UDPSocketMessageReceivedEventArgs args)
        {
            MessageReceived?.Invoke(this, args);
        }


        public void Destroy()
        {
            destroyed = true;
            listener.Stop();
        }
    }

    public class ClientObject
    {
        public TcpClient client;
        public event EventHandler<UDPSocketMessageReceivedEventArgs> MessageReceived;
        public ClientObject(TcpClient tcpClient)
        {
            client = tcpClient;
        }

        public void Process()
        {
            NetworkStream stream = null;
            try
            {
                stream = client.GetStream();
                byte[] data = new byte[64]; // буфер для получаемых данных
                while (true)
                {
                    // получаем сообщение
                    StringBuilder builder = new StringBuilder();
                    int bytes = 0;
                    do
                    {
                        bytes = stream.Read(data, 0, data.Length);
                        builder.Append(Encoding.UTF8.GetString(data, 0, bytes));
                    }
                    while (stream.DataAvailable);

                    if (builder.Length > 0)
                    {
                        string message = builder.ToString();

                        Console.WriteLine(message);
                        // отправляем обратно сообщение в верхнем регистре
                        //message = message.Substring(message.IndexOf(':') + 1).Trim().ToUpper();
                        //data = Encoding.UTF8.GetBytes(message);
                        //stream.Write(data, 0, data.Length);
                        MessageReceived?.Invoke(this, new UDPSocketMessageReceivedEventArgs() { Endpoint = (IPEndPoint)client.Client.RemoteEndPoint, Message = message });

                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (stream != null)
                    stream.Close();
                if (client != null)
                    client.Close();
            }
        }
    }
}
