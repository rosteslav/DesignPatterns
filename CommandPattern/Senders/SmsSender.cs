using CommandPattern.Senders.Interfaces;
using System;

namespace CommandPattern.Senders
{
    public class SmsSender : AbstractSender, ISender
    {
        protected override void Send(string message)
        {
            Console.WriteLine($"Sending '{message}' to Sms...");
        }
    }
}
