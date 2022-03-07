namespace FlyweightPattern.Senders.Interface
{
    public interface ISender
    {
        string Platform { get; set; }

        void Send(string message);
    }
}
