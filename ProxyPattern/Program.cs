using ProxyPattern.Authenticators;
using ProxyPattern.Proxy;
using ProxyPattern.Senders;

namespace ProxyPattern
{
    class Program
    {
        static void Main()
        {
            SenderProxy proxy = new SenderProxy();
            proxy.Sender = new SmsSender();
            proxy.Authenticator = new SmsAuthenticator();
            proxy.Send("Hello!");

            proxy.Sender = new SlackSender();
            proxy.Authenticator = new SlackAuthenticator();
            proxy.Send("Hello!");

            proxy.Sender = new FacebookSender();
            proxy.Authenticator = new FacebookAuthenticator();
            proxy.Send("Hello!");
        }
    }
}
