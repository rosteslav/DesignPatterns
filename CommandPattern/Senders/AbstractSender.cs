using CommandPattern.Senders.Interfaces;
using System;

namespace CommandPattern.Senders
{
    public abstract class AbstractSender : ISender
    {
        public void SendHello()
        {
            Send("Hello!");
        }

        public void SendTime()
        {
            Send(DateTime.Now.TimeOfDay.ToString());
        }

        protected abstract void Send(string message);
    }
}
