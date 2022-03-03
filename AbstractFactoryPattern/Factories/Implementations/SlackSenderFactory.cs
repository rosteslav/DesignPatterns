using AbstractFactoryPattern.Factories.Interfaces;
using AbstractFactoryPattern.Senders;
using AbstractFactoryPattern.Senders.Interfaces;

namespace AbstractFactoryPattern.Factories.Implementations
{
    public class SlackSenderFactory : ISenderFactory
    {
        public ISender CreateSender()
        {
            return new SlackSender();
        }
    }
}
