using DependencyInjectionPattern.Senders.Interfaces;

namespace DependencyInjectionPattern.Managers
{
    public class MessageManager
    {
        private ISender sender;

        public MessageManager(ISender sender)
        {
            this.sender = sender;
        }

        public void MessageHello()
        {
            sender.Send("Hello!");
        }
    }
}
