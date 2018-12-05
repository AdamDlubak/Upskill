using System;

namespace Command
{
    public class Light : ISwitchable
    {
        bool _lightState;

        public void PowerOn()
        {
            CheckState(true, "The light is already turned on!", "The light is on");
        }

        public void PowerOff()
        {
            CheckState(false, "The light is already turned off!", "The light is off");
        }

        public void CheckState(bool state, string execption, string notification)
        {
            if (_lightState == state)
            {
                Console.WriteLine(execption);
            }
            else
            {
                Console.WriteLine(notification);
                _lightState = state;
            }
        }
    }
}