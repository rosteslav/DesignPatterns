using DecoratorPattern.Callers.Interfaces;
using DecoratorPattern.Senders;

namespace DecoratorPattern
{
    class Program
    {
        static void Main()
        {
            ISender baseSender = new SmsSender();
            baseSender = new SlackSender(baseSender);
            baseSender = new FacebookSender(baseSender);

            baseSender.Send("Hello!");
        }
    }
}
