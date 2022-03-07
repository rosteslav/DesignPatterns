namespace FlyweightPattern.Flyweight
{
    public static class MessagesPointer
    {
        public static readonly Messages Messages = new Messages()
        {
            SendMessageFormat = "Sending '{0}' to {1}..."
        };
    }
}
