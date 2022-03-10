using ProxyPattern.Senders.Interfaces;
using System;

namespace ProxyPattern.Senders
{
    public class FacebookSender : ISender
    {
        public void Send(string message)
        {
            Console.WriteLine($"Sending '{message}' to Facebook...");
        }
     }
}
