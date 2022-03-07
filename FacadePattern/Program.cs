using FacadePattern.Facades;

namespace FacadePattern
{
    class Program
    {
        static void Main()
        {
            SenderFacade facade = new SenderFacade();
            facade.Send("Hello");
        }
    }
}
