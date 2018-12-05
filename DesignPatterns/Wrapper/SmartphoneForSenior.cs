using System;
using System.Runtime.InteropServices.ComTypes;

namespace Wrapper
{
    public class SmartphoneForChild : ISmartphone
    {
        ISmartphone _smartphone = new Smartphone();

        public void Call(string number)
        {
            if(number.StartsWith("0 700"))
            {
                Console.WriteLine("Sorry, you cannot use number starts with 0 700, it's only for adults :)");
            }
            else
            {
                _smartphone.Call(number);
            }
        }

        public void SendMessage(string message, string attachment)
        {
            if (message.Length > 20)
            {
                Console.WriteLine("Sorry, your message is too long.");
            }
            else
            {
                _smartphone.SendMessage(message, attachment);
            }
        }

        public void PlayGame(string name)
        {
            if (name == "GTA V")
            {
                Console.WriteLine("Sorry, you cannot play this game, it's too drastic...");
            }
            else
            {
                _smartphone.PlayGame(name);
            }
        }
    }
}