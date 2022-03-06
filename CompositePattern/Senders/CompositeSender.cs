using CompositePattern.Senders.Interfaces;
using System.Collections.Generic;

namespace CompositePattern.Senders
{
    public class CompositeSender : ISender
    {
        ICollection<ISender> senders;

        public CompositeSender()
            : this(new List<ISender>())
        { 
        }

        public CompositeSender(ICollection<ISender> senders)
        {
            this.senders = senders;
        }

        public void Add(ISender sender)
        {
            senders.Add(sender);
        }

        public void Send(string message)
        {
            foreach (var sender in senders)
            {
                sender.Send(message);
            }
        }
    }
}
