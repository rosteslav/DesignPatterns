using System;

namespace BuilderPattern.Senders
{
    public class Sender
    {
        public string Platform { get; set; }

        public Sender(string platform)
        {
            Platform = platform;
        }

        public void Send(string message)
        {
            Console.WriteLine($"Sending '{message}' to {Platform}...");
        }
    }
}
