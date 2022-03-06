using AdapterPattern.Messangers.Interfaces;
using System;

namespace AdapterPattern.Messangers
{
    public class FacebookMessager : IMessager
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"Sending '{message}' to Facebook...");
        }
    }
}
