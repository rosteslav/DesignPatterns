using AbstractFactoryPattern.Factories.Enums;
using AbstractFactoryPattern.Factories.Implementations;
using AbstractFactoryPattern.Factories.Interfaces;
using System;

namespace AbstractFactoryPattern.Factories
{
    public class FactoryManager
    {
        public ISenderFactory GetSenderFacory(FactoriesEnum factory)
        {
            switch (factory)
            {
                case FactoriesEnum.Sms:
                    return new SmsSenderFactory();
                case FactoriesEnum.Facebook:
                    return new FacebookSenderFactory();
                case FactoriesEnum.Slack:
                    return new SlackSenderFactory();
                default:
                    throw new ArgumentException($"No such factory: {factory}");
            }
        }
    }
}
