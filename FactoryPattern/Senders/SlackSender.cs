using FactoryPattern.Senders.Interfaces;
using System;

namespace FactoryPattern.Senders
{
    public class SlackSender : ISender
    {
        public void Send(string message)
        {
            Console.WriteLine($"Sending '{message}' to Slack...");
        }
    }
}
