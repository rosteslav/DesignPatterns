using DecoratorPattern.Callers.Interfaces;
using System;

namespace DecoratorPattern.Senders
{
    public class SmsSender : AbstractSender, ISender
    {
        public SmsSender() : base() { }
        public SmsSender(ISender sender) : base(sender) { }

        public override void Send(string message)
        {
            Console.WriteLine($"Sending '{message}' to Sms...");
            base.Send(message);
        }
    }
}
