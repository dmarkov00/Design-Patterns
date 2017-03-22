using SoundDevices;
using System;

namespace Commands.Speakers
{
    public class TurnSpeakersOn : ICommand
    {
        private ISoundDevice soundDevice;
        public TurnSpeakersOn(ISoundDevice newSoundDevice)
        {
            soundDevice = newSoundDevice;
        }
        public string Execute()
        {
            return soundDevice.TurnOn();
        }
    }
}
