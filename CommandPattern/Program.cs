﻿using CommandPattern.Commands;
using CommandPattern.Commands.Interfaces;
using CommandPattern.Executors;
using CommandPattern.Senders;
using CommandPattern.Senders.Interfaces;

namespace CommandPattern
{
    class Program
    {
        static void Main()
        {
            ISender sender = new SmsSender();

            ICommand helloCommand = new HelloCommand(sender);
            ICommand timeCommand = new TimeCommand(sender);

            Executor executor = new Executor(helloCommand, timeCommand);

            executor.SayHello();
            executor.TellTime();
        }
    }
}
