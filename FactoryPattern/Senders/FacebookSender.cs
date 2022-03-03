using FactoryPattern.Senders.Interfaces;
using System;

namespace FactoryPattern.Senders
{
    public class FacebookSender : ISender
    {
        public void Send(string message)
        {
            Console.WriteLine($"Sending '{message}' to Facebook...");
        }
    }
}
