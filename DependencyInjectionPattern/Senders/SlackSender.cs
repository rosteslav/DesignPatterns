using DependencyInjectionPattern.Senders.Interfaces;
using System;

namespace DependencyInjectionPattern.Senders
{
    public class SlackSender : ISender
    {
        public void Send(string message)
        {
            Console.WriteLine($"Sending '{message}' to Slack...");
        }
    }
}
