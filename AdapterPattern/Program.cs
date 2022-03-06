using AdapterPattern.Adapters;
using AdapterPattern.Messangers;
using AdapterPattern.Messangers.Interfaces;
using AdapterPattern.Senders;
using AdapterPattern.Senders.Interfaces;

namespace AdapterPattern
{
    class Program
    {
        static void Main()
        {
            ISender sender = new SmsSender();
            sender.Send("Hello!");

            IMessager messager = new FacebookMessager();
            MessagerToSenderAdapter adapter = new MessagerToSenderAdapter(messager);
            adapter.Send("Hello!");
        }
    }
}
