using DecoratorPattern.Callers.Interfaces;
using System;

namespace DecoratorPattern.Senders
{
    public class SlackSender : AbstractSender, ISender
    {
        public SlackSender() : base() { }
        public SlackSender(ISender caller) : base(caller) { }

        public override void Send(string message)
        {
            Console.WriteLine($"Sending '{message}' to Slack...");
            base.Send(message);
        }
    }
}
