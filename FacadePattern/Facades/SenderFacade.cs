using FacadePattern.Processes;
using FacadePattern.Processes.Interface;

namespace FacadePattern.Facades
{
    public class SenderFacade
    {
        public void Send(string message)
        {
            IAuthenticator authenticator = new FacebookAuthenticator();
            authenticator.Authenticate();

            ISender sender = new FacebookSender();
            sender.Send(message);
        }
    }
}
