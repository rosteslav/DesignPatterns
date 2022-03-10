using ProxyPattern.Authenticators.Interfaces;

namespace ProxyPattern.Authenticators
{
    class FacebookAuthenticator : IAuthenticator
    {
        public bool Authenticate()
        {
            return false;
        }
    }
}
