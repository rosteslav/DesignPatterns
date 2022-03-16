using CommandPattern.Commands.Interfaces;
using CommandPattern.Senders.Interfaces;

namespace CommandPattern.Commands
{
    class HelloCommand : ICommand
    {
        ISender sender;

        public HelloCommand(ISender sender)
        {
            this.sender = sender;
        }

        public void Execute()
        {
            sender.SendHello();
        }
    }
}
