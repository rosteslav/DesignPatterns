using AbstractFactoryPattern.Factories.Interfaces;
using AbstractFactoryPattern.Senders;
using AbstractFactoryPattern.Senders.Interfaces;

namespace AbstractFactoryPattern.Factories.Implementations
{
    public class SmsSenderFactory : ISenderFactory
    {
        public ISender CreateSender()
        {
            return new SmsSender();
        }
    }
}
