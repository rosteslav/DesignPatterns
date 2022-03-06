using BridgePattern.Senders.Interfaces;
using System;

namespace BridgePattern.Senders
{
    public class SlackSender : ISender
    {
        public void Send(string message)
        {
            Console.WriteLine($"Sending '{message}' to Slack...");
        }
    }
}
