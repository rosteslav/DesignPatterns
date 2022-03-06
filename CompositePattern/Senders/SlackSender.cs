using CompositePattern.Senders.Interfaces;
using System;

namespace CompositePattern.Senders
{
    public class SlackSender : ISender
    {
        public void Send(string message)
        {
            Console.WriteLine($"Sending '{message}' to Slack...");
        }
    }
}
