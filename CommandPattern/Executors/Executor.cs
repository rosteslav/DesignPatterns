using CommandPattern.Commands.Interfaces;

namespace CommandPattern.Executors
{
    public class Executor
    {
        ICommand helloCommand;
        ICommand timeCommand;

        public Executor(ICommand helloCommand, ICommand timeCommand)
        {
            this.helloCommand = helloCommand;
            this.timeCommand = timeCommand;
        }

        public void SayHello()
        {
            helloCommand.Execute();
        }

        public void TellTime()
        {
            timeCommand.Execute();
        }
    }
}
