using LazyInitializationPattern.Managers;
using LazyInitializationPattern.Senders.Enums;

var senderManager = new SenderManager();
senderManager.SendMessage(SenderEnum.Sms, "Hello!");
senderManager.SendMessage(SenderEnum.Slack, "Hello!");
senderManager.SendMessage(SenderEnum.Facebook, "Hello!");