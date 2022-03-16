using CommandPattern.Commands.Interfaces;
using CommandPattern.Senders.Interfaces;

namespace CommandPattern.Commands
{
    class TimeCommand : ICommand
    {
        ISender sender;

        public TimeCommand(ISender sender)
        {
            this.sender = sender;
        }

        public void Execute()
        {
            sender.SendTime();
        }
    }
}
