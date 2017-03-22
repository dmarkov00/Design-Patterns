using SoundDevices;
using System;

namespace Commands.Speakers
{
    public class TurnSpeakersVolumeUp : ICommand
    {
        private ISoundDevice soundDevice;
        public TurnSpeakersVolumeUp(ISoundDevice newSoundDevice)
        {
            soundDevice = newSoundDevice;
        }
        public string Execute()
        {
            return soundDevice.VolumeUp();
        }
    }
}
