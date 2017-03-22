using SoundDevices;
using System;

namespace Commands.Speakers
{
    public class TurnSpeakersVolumeDown : ICommand
    {
        private ISoundDevice soundDevice;
        public TurnSpeakersVolumeDown(ISoundDevice newSoundDevice)
        {
            soundDevice = newSoundDevice;
        }
        public string Execute()
        {
            return soundDevice.VolumeDown();
        }
    }
}
