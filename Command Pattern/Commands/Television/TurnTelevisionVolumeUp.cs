using SoundDevices;
using System;

namespace Commands.Television
{
    public class TurnTelevisionVolumeUp : ICommand
    {
        private ISoundDevice soundDevice;
        public TurnTelevisionVolumeUp(ISoundDevice newSoundDevice)
        {
            soundDevice = newSoundDevice;
        }
        public string Execute()
        {
            return soundDevice.VolumeUp();
        }
    }
}
