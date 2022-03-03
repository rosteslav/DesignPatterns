using AbstractFactoryPattern.Factories;
using AbstractFactoryPattern.Factories.Enums;
using AbstractFactoryPattern.Factories.Interfaces;
using AbstractFactoryPattern.Senders.Interfaces;
using System;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main()
        {
            var factoryManager = new FactoryManager();

            ISenderFactory factory = factoryManager.GetSenderFacory(FactoriesEnum.Sms);
            ISender sender = factory.CreateSender();
            sender.Send("Hello!");
        }
    }
}
