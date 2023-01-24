using ChainOfResponsibilityPattern.Senders;
using ChainOfResponsibilityPattern.Senders.Interfaces;

ISender sender = new SmsSender();
sender.Next = new SlackSender();
sender.Next = new FacebookSender();

sender.Send("Hello!");