namespace ChainOfResponsibilityPattern.Senders.Interfaces
{
    public interface ISender
    {
        ISender Next { set; }
        void Send(string message);
    }
}
