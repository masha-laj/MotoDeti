using System;
using System.Collections.Generic;
using System.Linq;

namespace MotoDeti
{
    public class MobileCOntrolEventArgs: EventArgs
    {
        public string Address { get; set; }
        public List<string> Args { get; set; }
    }

    public class MobileControl
    {
        private UDPSocket socket = new UDPSocket("235.5.5.1", 8001);

        public event EventHandler<MobileCOntrolEventArgs> Connected;
        public event EventHandler<MobileCOntrolEventArgs> AnswerReceived;
        public event EventHandler<MobileCOntrolEventArgs> Disconnected;

        public MobileControl()
        {
            socket.MessageReceived += Socket_MessageReceived;
        }

        private void Socket_MessageReceived(object sender, UDPSocketMessageReceivedEventArgs e)
        {
            var address = e.Endpoint.Address.ToString();
            var message = e.Message;
            
            var parts = message.Split('_');
            var command = parts[0];
            List<string> args = parts.ToList().GetRange(1, parts.Length - 1);
            
            switch (command)
            {
                case "connect":
                    Connected?.Invoke(this, new MobileCOntrolEventArgs() { Address = address, Args = args });
                    break;
                case "answer":
                    AnswerReceived?.Invoke(this, new MobileCOntrolEventArgs() { Address = address, Args = args });
                    break;
                case "disconnect":
                    Disconnected?.Invoke(this, new MobileCOntrolEventArgs() { Address = address, Args = args });
                    break;
            }
        }

        public void Destroy()
        {
            socket.Destroy();
        }
    }
}
