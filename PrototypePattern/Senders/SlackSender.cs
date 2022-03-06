using PrototypePattern.Senders.Abstract;

namespace PrototypePattern.Senders
{
    public class SlackSender : AbstractSender
    {
        public SlackSender()
        {
            Platform = "Slack";
        }

        public override AbstractSender Clone()
        {
            return (AbstractSender)MemberwiseClone();
        }
    }
}
