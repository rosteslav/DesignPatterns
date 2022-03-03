using AbstractFactoryPattern.Senders.Interfaces;

namespace AbstractFactoryPattern.Factories.Interfaces
{
    public interface ISenderFactory
    {
        ISender CreateSender();
    }
}
