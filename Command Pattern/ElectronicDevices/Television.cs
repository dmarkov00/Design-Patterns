namespace SoundDevices
{
    public class Television : ISoundDevice
    {
        private int _volume;
        public string TurnOff()
        {
            return "The TELEVISION is OFF";
        }

        public string TurnOn()
        {
            return "The TELEVISION is ON";
        }

        public string VolumeDown()
        {
            _volume--;
            return "The volume of the TELEVISION is turned DOWN to " + _volume;
        }

        public string VolumeUp()
        {
            _volume++;
            return "The volume of the TELEVISION is turned UP to " + _volume;
        }
    }
}
