using ChainOfResponsibilityPattern.Senders.Interfaces;

namespace ChainOfResponsibilityPattern.Senders
{
    public abstract class AbstractSender : ISender
    {
        private AbstractSender next;

        public ISender Next
        {
            set
            {
                AbstractSender lastSender = this;

                while (lastSender.next != null)
                {
                    lastSender = lastSender.next;
                }

                if (value is AbstractSender)
                {
                    lastSender.next = value as AbstractSender;
                }
            }
        }

        public void Send(string message)
        {
            SendMessage(message);

            if (next != null)
            {
                next.Send(message);
            }
        }

        abstract protected void SendMessage(string message);
    }
}
