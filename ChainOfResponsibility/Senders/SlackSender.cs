using ChainOfResponsibility.Senders.Interfaces;
using System;

namespace ChainOfResponsibility.Senders
{
    public class SlackSender : AbstractSender, ISender
    {
        protected override void SendMessage(string message)
        {
            Console.WriteLine($"Sending '{message}' to Slack...");
        }
    }
}
