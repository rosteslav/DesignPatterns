using ProxyPattern.Authenticators.Interfaces;

namespace ProxyPattern.Authenticators
{
    public class SlackAuthenticator : IAuthenticator
    {
        public bool Authenticate()
        {
            return false;
        }
    }
}
