using ProxyPattern.Authenticators.Interfaces;
using ProxyPattern.Senders.Interfaces;
using System;

namespace ProxyPattern.Proxy
{
    public class SenderProxy : ISender
    {
        public ISender Sender { get; set; }
        public IAuthenticator Authenticator { get; set; }

        public void Send(string message)
        {
            if (Authenticator.Authenticate())
            {
                Sender.Send(message);
            }
            else
            {
                Console.WriteLine("Authentication failed!");
            }
        }
    }
}
