using BridgePattern.Messagers;
using BridgePattern.Messagers.Interfaces;
using BridgePattern.Senders;
using BridgePattern.Senders.Interfaces;

ISender sender = new SmsSender();
IMessager messager = new Messager(sender);
messager.Message("Hello!");
