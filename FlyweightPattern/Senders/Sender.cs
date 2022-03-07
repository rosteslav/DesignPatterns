using FlyweightPattern.Flyweight;
using FlyweightPattern.Senders.Interface;
using System;

namespace FlyweightPattern.Senders
{
    public class Sender : ISender
    {
        public string Platform { get; set; }

        private string messageFormat => MessagesPointer.Messages.SendMessageFormat;

        public void Send(string message)
        {
            Console.WriteLine(string.Format(messageFormat, message, Platform));
        }
    }
}
