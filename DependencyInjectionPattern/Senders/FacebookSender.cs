using DependencyInjectionPattern.Senders.Interfaces;
using System;

namespace DependencyInjectionPattern.Senders
{
    class FacebookSender : ISender
    {
        public void Send(string message)
        {
            Console.WriteLine($"Sending '{message}' to Facebook...");
        }
    }
}
