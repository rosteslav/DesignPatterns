using BuilderPattern.Builders;
using BuilderPattern.Directors;

var builder = new SmsSenderBuilder();
var director = new SenderDirector(builder);
var sender = director.MakeSender();
sender.Send("Hello!");