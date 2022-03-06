using BridgePattern.Messagers;
using BridgePattern.Messagers.Interfaces;
using BridgePattern.Senders;
using BridgePattern.Senders.Interfaces;

namespace BridgePattern
{
    class Program
    {
        static void Main()
        {
            ISender sender = new SmsSender();
            IMessager messager = new Messager(sender);
            messager.Message("Hello!");
        }
    }
}
