using PrototypePattern.Senders.Abstract;

namespace PrototypePattern.Senders
{
    public class SmsSender : AbstractSender
    {
        public SmsSender()
        {
            Platform = "Sms";
        }

        public override AbstractSender Clone()
        {
            return (AbstractSender)MemberwiseClone();
        }
    }
}
