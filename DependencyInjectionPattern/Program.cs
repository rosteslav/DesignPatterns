using DependencyInjectionPattern.Managers;
using DependencyInjectionPattern.Senders;

namespace DependencyInjectionPattern
{
    class Program
    {
        static void Main()
        {
            var manager = new MessageManager(new SmsSender());
            manager.MessageHello();

            manager = new MessageManager(new SlackSender());
            manager.MessageHello();

            manager = new MessageManager(new FacebookSender());
            manager.MessageHello();
        }
    }
}
