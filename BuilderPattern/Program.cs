using BuilderPattern.Builders;
using BuilderPattern.Directors;

namespace BuilderPattern
{
    class Program
    {
        static void Main()
        {
            var builder = new SmsSenderBuilder();
            var director = new SenderDirector(builder);
            var sender = director.MakeSender();
            sender.Send("Hello!");
        }
    }
}
