using PrototypePattern.Senders;
using PrototypePattern.Senders.Abstract;

SmsSender sender = new SmsSender();
sender.Send("Hello!");

AbstractSender senderCopy = sender.Clone();
senderCopy.Send("Hi!");