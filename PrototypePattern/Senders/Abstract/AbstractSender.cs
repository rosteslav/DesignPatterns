using System;

namespace PrototypePattern.Senders.Abstract
{
    public abstract class AbstractSender
    {
        public string Platform { get; protected set; }

        public void Send(string message)
        {
            Console.WriteLine($"Sending '{message}' to {Platform}...");
        }

        public abstract AbstractSender Clone();
    }
}
