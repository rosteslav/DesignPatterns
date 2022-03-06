using BridgePattern.Senders.Interfaces;
using System;

namespace BridgePattern.Senders
{
    public class SmsSender : ISender
    {
        public void Send(string message)
        {
            Console.WriteLine($"Sending '{message}' to Sms...");
        }
    }
}
