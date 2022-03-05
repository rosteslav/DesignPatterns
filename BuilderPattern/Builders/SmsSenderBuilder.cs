using BuilderPattern.Builders.Interfaces;
using BuilderPattern.Senders;

namespace BuilderPattern.Builders
{
    public class SmsSenderBuilder : ISenderBuilder
    {
        public string Platform { get; private set; } = "Sms";

        public Sender MakeSender()
        {
            return new Sender(Platform);
        }
    }
}
