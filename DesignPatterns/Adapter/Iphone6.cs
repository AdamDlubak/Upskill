using System;

namespace Adapter
{
    interface Iiphone6
    {
        void ProtectedFromWater(bool ifprotected);
        void SpeedWorking(string speed);
        void SizeOfScreen(int inch);
    }

    class Iphone6 : Iiphone6
    {
        public void SizeOfScreen(int inch)
        {
            Console.WriteLine("Screen size in inches: " + inch);
        }

        public void SpeedWorking(string speed)
        {
            Console.WriteLine("IPhone speed: " + speed);
        }

        public void ProtectedFromWater(bool ifprotected)
        {
            Console.WriteLine("Is it protected from water? " + ifprotected);
        }
    }
}