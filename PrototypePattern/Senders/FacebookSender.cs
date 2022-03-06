using PrototypePattern.Senders.Abstract;

namespace PrototypePattern.Senders
{
    public class FacebookSender : AbstractSender
    {
        public FacebookSender()
        {
            Platform = "Facebook";
        }

        public override AbstractSender Clone()
        {
            return (AbstractSender)MemberwiseClone();
        }
    }
}
