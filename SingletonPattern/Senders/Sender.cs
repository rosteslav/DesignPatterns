using System;

namespace SingletonPattern.Senders
{
    public sealed class Sender
    {
        private static Sender instance = null;
        private static readonly object padlock = new object();

        public static Sender Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new Sender();
                    }

                    return instance;
                }
            }
        }

        public void Send(string message)
        {
            Console.WriteLine($"Sending '{message}'...");
        }
    }
}
