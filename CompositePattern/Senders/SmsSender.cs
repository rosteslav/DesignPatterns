using CompositePattern.Senders.Interfaces;
using System;

namespace CompositePattern.Senders
{
    public class SmsSender : ISender
    {
        public void Send(string message)
        {
            Console.WriteLine($"Sending '{message}' to Sms...");
        }
    }
}
