using FactoryPattern.Senders;
using FactoryPattern.Senders.Enums;
using FactoryPattern.Senders.Interfaces;
using System;

namespace FactoryPattern.Factory
{
    public class SenderFactory
    {
        public ISender GetSender(SenderEnum sender)
        {
            switch (sender)
            {
                case SenderEnum.Sms:
                    return new SmsSender();
                case SenderEnum.Facebook:
                    return new FacebookSender();
                case SenderEnum.Slack:
                    return new SlackSender();
                default:
                    throw new ArgumentException($"No such sender: {sender}");
            }
        }
    }
}
