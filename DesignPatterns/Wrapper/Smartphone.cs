using System;

namespace Wrapper
{

    interface ISmartphone
    {
        void Call(string number);
        void SendMessage(string message, string attachment);
        void PlayGame(string name);
    }

    public class Smartphone : ISmartphone
    {
        public void Call(string number)
        {
            Console.WriteLine("Calling to: " + number);
        }

        public void SendMessage(string message, string attachment)
        {
            Console.WriteLine("Sending message: \"" + message + "\" with attachment: \"" + attachment + "\"");
        }

        public void PlayGame(string name)
        {
            Console.WriteLine("Playing in " + name);
        }
    }
}