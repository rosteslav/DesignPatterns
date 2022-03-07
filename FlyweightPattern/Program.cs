using FlyweightPattern.Senders;
using FlyweightPattern.Senders.Interface;

namespace FlyweightPattern
{
    class Program
    {
        static void Main()
        {
            ISender sender = new Sender();
            sender.Platform = "Sms";
            sender.Send("Hello!");

            sender.Platform = "Slack";
            sender.Send("Hello!");

            sender.Platform = "Facebook";
            sender.Send("Hello!");
        }
    }
}
