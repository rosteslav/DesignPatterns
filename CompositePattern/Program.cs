using CompositePattern.Senders;

namespace CompositePattern
{
    class Program
    {
        static void Main()
        {
            var appSenders = new CompositeSender();
            appSenders.Add(new SlackSender());
            appSenders.Add(new FacebookSender());

            var senders = new CompositeSender();
            senders.Add(new SmsSender());
            senders.Add(appSenders);

            senders.Send("Hello!");
        }
    }
}
