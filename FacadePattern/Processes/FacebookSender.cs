using FacadePattern.Processes.Interface;
using System;

namespace FacadePattern.Processes
{
    public class FacebookSender : ISender
    {
        public void Send(string message)
        {
            Console.WriteLine($"Sending '{message}' to Facebook...");
        }
    }
}
