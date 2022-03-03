using AbstractFactoryPattern.Senders.Interfaces;
using System;

namespace AbstractFactoryPattern.Senders
{
    public class SlackSender : ISender
    {
        public void Send(string message)
        {
            Console.WriteLine($"Sending '{message}' to Slack...");
        }
    }
}
