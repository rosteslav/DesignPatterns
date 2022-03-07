using FacadePattern.Processes.Interface;
using System;

namespace FacadePattern.Processes
{
    public class FacebookAuthenticator : IAuthenticator
    {
        public void Authenticate()
        {
            Console.WriteLine("Authenticated to Facebook...");
        }
    }
}
