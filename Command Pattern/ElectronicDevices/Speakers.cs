using System;

namespace SoundDevices
{
    public class Speakers : ISoundDevice
    {
        private int _volume;
        public string TurnOff()
        {
            return "The speakers are OFF";
        }

        public string TurnOn()
        {
            return "The SPEAKERS are ON";
        }

        public string VolumeDown()
        {
            _volume--;
            return "The volume of the SPEAKERS is turned DOWN to " + _volume;
        }

        public string VolumeUp()
        {
            _volume++;
            return "The volume of the SPEAKERS is turned UP to " + _volume;
        }
    }
}
