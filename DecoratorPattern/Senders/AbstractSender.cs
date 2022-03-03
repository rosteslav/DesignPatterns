using DecoratorPattern.Callers.Interfaces;

namespace DecoratorPattern.Senders
{
    public abstract class AbstractSender : ISender
    {
        ISender baseSender;

        public AbstractSender(ISender sender)
        {
            baseSender = sender;
        }

        public AbstractSender()
            : this(null)
        {
        }

        public virtual void Send(string message)
        {
            if (baseSender != null)
            {
                baseSender.Send(message);
            }
        }
    }
}
