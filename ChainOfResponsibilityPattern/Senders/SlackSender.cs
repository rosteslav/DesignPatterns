﻿using ChainOfResponsibilityPattern.Senders.Interfaces;
using System;

namespace ChainOfResponsibilityPattern.Senders
{
    public class SlackSender : AbstractSender, ISender
    {
        protected override void SendMessage(string message)
        {
            Console.WriteLine($"Sending '{message}' to Slack...");
        }
    }
}
