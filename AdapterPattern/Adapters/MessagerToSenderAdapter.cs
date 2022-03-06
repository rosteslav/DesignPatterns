using AdapterPattern.Messangers.Interfaces;
using AdapterPattern.Senders.Interfaces;

namespace AdapterPattern.Adapters
{
    public class MessagerToSenderAdapter : ISender
    {
        private readonly IMessager messager;

        public MessagerToSenderAdapter(IMessager messager)
        {
            this.messager = messager;
        }

        public void Send(string message)
        {
            messager.SendMessage(message);
        }
    }
}
