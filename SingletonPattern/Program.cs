using SingletonPattern.Senders;

namespace SingletonPattern
{
    class Program
    {
        static void Main()
        {
            Sender.Instance.Send("Hello!");
            Sender.Instance.Send("Hello!");
        }
    }
}
