using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("iphone6 parameters");

            Iphone6 iphone6 = new Iphone6();
            iphone6.ProtectedFromWater(true); //Is it protected from water? true
            iphone6.SizeOfScreen(3);          //Screen size in inches: 3
            iphone6.SpeedWorking("Slow");     //IPhone speed: Slow

            Console.WriteLine("\niphone7 parameters");

            IphoneAdapter iphone6Adapter = new IphoneAdapter();
            iphone6Adapter.ProtectedFromWater(true); //Is it protected from water? true
            iphone6Adapter.SizeOfScreen(4);          //Screen size in inches: 4
            iphone6Adapter.SpeedWorking("Fast");     //IPhone speed: Fast

            Console.ReadKey();
        }
    }
}
