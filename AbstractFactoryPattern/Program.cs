using AbstractFactoryPattern.Factories;
using AbstractFactoryPattern.Factories.Enums;
using AbstractFactoryPattern.Factories.Interfaces;
using AbstractFactoryPattern.Senders.Interfaces;

var factoryManager = new FactoryManager();

ISenderFactory factory = factoryManager.GetSenderFacory(FactoriesEnum.Sms);
ISender sender = factory.CreateSender();
sender.Send("Hello!");