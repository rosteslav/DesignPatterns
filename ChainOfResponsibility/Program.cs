using ChainOfResponsibility.Senders;
using ChainOfResponsibility.Senders.Interfaces;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main()
        {
            ISender sender = new SmsSender();
            sender.Next = new SlackSender();
            sender.Next = new FacebookSender();

            sender.Send("Hello!");
        }
    }
}
