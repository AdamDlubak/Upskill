namespace Adapter
{
    class IphoneAdapter : Iiphone6
    {
        Iiphone7 _iphone7 = new Iphone7();
        public void ProtectedFromWater(bool ifprotected)
        {
            _iphone7.PhoneIsProtectedFromWater(ifprotected);
        }

        public void SizeOfScreen(int inch)
        {
            _iphone7.PhoneSizeScreen(inch);
        }

        public void SpeedWorking(string speed)
        {
            _iphone7.SpeedPhoneWorking(speed);
        }
    }
}