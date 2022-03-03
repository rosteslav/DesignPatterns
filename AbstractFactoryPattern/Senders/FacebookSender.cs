using AbstractFactoryPattern.Senders.Interfaces;
using System;

namespace AbstractFactoryPattern.Senders
{
    public class FacebookSender : ISender
    {
        public void Send(string message)
        {
            Console.WriteLine($"Sending '{message}' to Facebook...");
        }
    }
}
