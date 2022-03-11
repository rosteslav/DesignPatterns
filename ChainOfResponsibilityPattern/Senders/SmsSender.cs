using ChainOfResponsibilityPattern.Senders.Interfaces;
using System;

namespace ChainOfResponsibilityPattern.Senders
{
    public class SmsSender : AbstractSender, ISender
    {
        protected override void SendMessage(string message)
        {
            Console.WriteLine($"Sending '{message}' to Sms...");
        }
    }
}
