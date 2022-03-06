using BridgePattern.Messagers.Interfaces;
using BridgePattern.Senders.Interfaces;

namespace BridgePattern.Messagers
{
    public class Messager : IMessager
    {
        ISender sender;

        public Messager(ISender sender)
        {
            this.sender = sender;
        }

        public void Message(string message)
        {
            sender.Send(message);
        }
    }
}
