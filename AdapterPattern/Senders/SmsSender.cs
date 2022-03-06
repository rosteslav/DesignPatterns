using AdapterPattern.Senders.Interfaces;
using System;

namespace AdapterPattern.Senders
{
    public class SmsSender : ISender
    {
        public void Send(string message)
        {
            Console.WriteLine($"Sending '{message}' to Sms...");
        }
    }
}
