using DecoratorPattern.Callers.Interfaces;
using DecoratorPattern.Senders;

ISender baseSender = new SmsSender();
baseSender = new SlackSender(baseSender);
baseSender = new FacebookSender(baseSender);

baseSender.Send("Hello!");