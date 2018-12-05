using System;

namespace Adapter
{
    interface Iiphone7
    {
        void PhoneIsProtectedFromWater(bool ifprotected);
        void SpeedPhoneWorking(string speed);
        void PhoneSizeScreen(int inch);
    }
    class Iphone7 : Iiphone7
    {
        public void PhoneSizeScreen(int inch)
        {
            Console.WriteLine("Screen size in inches: " + inch);
        }

        public void SpeedPhoneWorking(string speed)
        {
            Console.WriteLine("IPhone speed: " + speed);
        }

        public void PhoneIsProtectedFromWater(bool ifprotected)
        {
            Console.WriteLine("Is it protected from water? " + ifprotected);
        }
    }
}