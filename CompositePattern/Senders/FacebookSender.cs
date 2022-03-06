using CompositePattern.Senders.Interfaces;
using System;

namespace CompositePattern.Senders
{
    public class FacebookSender : ISender
    {
        public void Send(string message)
        {
            Console.WriteLine($"Sending '{message}' to Facebook...");
        }
    }
}
