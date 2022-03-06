using BridgePattern.Senders.Interfaces;
using System;

namespace BridgePattern.Senders
{
    public class FacebookSender : ISender
    {
        public void Send(string message)
        {
            Console.WriteLine($"Sending '{message}' to Facebook...");
        }
    }
}
