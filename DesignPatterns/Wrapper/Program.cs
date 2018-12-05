using System;

namespace Wrapper
{
    class Program
    {
        static void Main(string[] args)
        {
            ISmartphone smartphone = new Smartphone();
            smartphone.Call("0 700 xxx xxx");
            smartphone.SendMessage("Message content longer than 20", "Attachment name");
            smartphone.PlayGame("GTA V");

            ISmartphone smarphoneForChild = new SmartphoneForChild();
            smarphoneForChild.Call("0 700 xxx xxx");
            smarphoneForChild.SendMessage("Message content longer than 20", "Attachment name");
            smarphoneForChild.PlayGame("GTA V");

            Console.ReadKey();
        }
    }
}
