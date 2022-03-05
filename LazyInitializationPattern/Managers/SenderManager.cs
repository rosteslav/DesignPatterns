using LazyInitializationPattern.Senders;
using LazyInitializationPattern.Senders.Enums;
using LazyInitializationPattern.Senders.Interfaces;
using System;
using System.Collections.Generic;

namespace LazyInitializationPattern.Managers
{
    public class SenderManager
    {
        private Dictionary<SenderEnum, ISender> dict;

        public SenderManager()
        {
            dict = new Dictionary<SenderEnum, ISender>();
        }

        public void SendMessage(SenderEnum type, string message)
        {
            if (!dict.ContainsKey(type))
            {
                dict.Add(type, makeSender(type));
            }

            dict[type].Send(message);
        }

        private ISender makeSender(SenderEnum type)
        {
            switch (type)
            {
                case SenderEnum.Sms:
                    return new SmsSender();
                case SenderEnum.Facebook:
                    return new FacebookSender();
                case SenderEnum.Slack:
                    return new SlackSender();
                default:
                    throw new ArgumentException($"Invalid type: {type}");
            }
        }
    }
}
