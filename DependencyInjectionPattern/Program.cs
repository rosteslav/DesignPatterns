using DependencyInjectionPattern.Managers;
using DependencyInjectionPattern.Senders;

var manager = new MessageManager(new SmsSender());
manager.MessageHello();

manager = new MessageManager(new SlackSender());
manager.MessageHello();

manager = new MessageManager(new FacebookSender());
manager.MessageHello();