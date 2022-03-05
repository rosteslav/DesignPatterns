using BuilderPattern.Builders.Interfaces;
using BuilderPattern.Senders;

namespace BuilderPattern.Directors
{
    public class SenderDirector
    {
        private ISenderBuilder builder;

        public SenderDirector(ISenderBuilder builder)
        {
            this.builder = builder;
        }

        public Sender MakeSender()
        {
            return builder.MakeSender();
        }
    }
}
