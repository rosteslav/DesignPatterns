using LazyInitializationPattern.Senders.Interfaces;
using System;

namespace LazyInitializationPattern.Senders
{
    public class SlackSender : ISender
    {
        public void Send(string message)
        {
            Console.WriteLine($"Sending '{message}' to Slack...");
        }
    }
}
