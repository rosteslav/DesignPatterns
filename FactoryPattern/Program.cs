using FactoryPattern.Factory;
using FactoryPattern.Senders.Enums;
using FactoryPattern.Senders.Interfaces;

var factory = new SenderFactory();
ISender sender = factory.GetSender(SenderEnum.Sms);
sender.Send("Hello!");