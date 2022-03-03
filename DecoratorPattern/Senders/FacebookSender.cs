using DecoratorPattern.Callers.Interfaces;
using System;

namespace DecoratorPattern.Senders
{
    public class FacebookSender : AbstractSender, ISender
    {
        public FacebookSender() : base() { }
        public FacebookSender(ISender caller) : base(caller) { }

        public override void Send(string message)
        {
            Console.WriteLine($"Sending '{message}' to Facebook...");
            base.Send(message);
        }
    }
}
