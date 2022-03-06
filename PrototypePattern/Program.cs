using PrototypePattern.Senders;
using PrototypePattern.Senders.Abstract;

namespace PrototypePattern
{
    class Program
    {
        static void Main()
        {
            SmsSender sender = new SmsSender();
            sender.Send("Hello!");

            AbstractSender senderCopy = sender.Clone();
            senderCopy.Send("Hi!");
        }
    }
}
