using BuilderPattern.Senders;

namespace BuilderPattern.Builders.Interfaces
{
    public interface ISenderBuilder
    {
        string Platform { get; }

        Sender MakeSender();
    }
}
