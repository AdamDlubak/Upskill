using System;

namespace Command
{
    class Program
    {
        public static void Main(string[] arguments)
        {
            string argument;

            ISwitchable lamp = new Light();

            ICommand switchClose = new CloseSwitchCommand(lamp);
            ICommand switchOpen = new OpenSwitchCommand(lamp);

            var switchAction = new Switch(switchClose, switchOpen);

            while (!string.IsNullOrEmpty(argument = Console.ReadLine()))
            {
                switch(argument)
                {
                    case "ON":
                        switchAction.Open();
                        break;
                    case "OFF":
                        switchAction.Close();
                        break;
                    default:
                        Console.WriteLine("Argument \"ON\" or \"OFF\" is required.");
                        break;
                }
            }

            Console.ReadKey();
        }
    }
}
