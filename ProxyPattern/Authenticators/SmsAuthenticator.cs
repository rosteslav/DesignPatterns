using ProxyPattern.Authenticators.Interfaces;

namespace ProxyPattern.Authenticators
{
    class SmsAuthenticator : IAuthenticator
    {
        public bool Authenticate()
        {
            return true;
        }
    }
}
