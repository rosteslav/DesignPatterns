using BuilderPattern.Builders.Interfaces;
using BuilderPattern.Senders;

namespace BuilderPattern.Builders
{
    public class FacebookSenderBuilder : ISenderBuilder
    {
        public string Platform { get; private set; } = "Facebook";

        public Sender MakeSender()
        {
            return new Sender(Platform);
        }
    }
}
