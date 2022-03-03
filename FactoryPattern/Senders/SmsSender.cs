using FactoryPattern.Senders.Interfaces;
using System;

namespace FactoryPattern.Senders
{
    public class SmsSender : ISender
    {
        public void Send(string message)
        {
            Console.WriteLine($"Sending '{message}' to Sms...");
        }
    }
}
