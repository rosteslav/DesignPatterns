using DecoratorPattern.Senders;

namespace DecoratorPattern
{
    class Program
    {
        static void Main()
        {
            var smsSender = new SmsSender();
            var slackSender = new SlackSender(smsSender);
            var facebookSender = new FacebookSender(slackSender);

            facebookSender.Send("Hello!");
        }
    }
}
