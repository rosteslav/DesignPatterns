using ChainOfResponsibilityPattern.Senders.Interfaces;

namespace ChainOfResponsibilityPattern.Senders;

public class SmsSender : AbstractSender, ISender
{
    protected override void SendMessage(string message)
    {
        Console.WriteLine($"Sending '{message}' to Sms...");
    }
}
