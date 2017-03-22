using SoundDevices;
using System;

namespace Commands.Speakers
{
    public class TurnSpeakersOff : ICommand
    {
        private ISoundDevice soundDevice;
        public TurnSpeakersOff(ISoundDevice newSoundDevice)
        {
            soundDevice = newSoundDevice;
        }
        public string Execute()
        {
            return soundDevice.TurnOff();
        }
    }
}
