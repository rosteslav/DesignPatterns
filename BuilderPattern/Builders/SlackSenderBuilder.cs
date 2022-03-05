using BuilderPattern.Builders.Interfaces;
using BuilderPattern.Senders;

namespace BuilderPattern.Builders
{
    public class SlackSenderBuilder : ISenderBuilder
    {
        public string Platform { get; private set; } = "Slack";

        public Sender MakeSender()
        {
            return new Sender(Platform);
        }
    }
}
