using ChainOfResponsibilityPattern.Senders;
using ChainOfResponsibilityPattern.Senders.Interfaces;

namespace ChainOfResponsibilityPattern
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
