using SoundDevices;
using System;

namespace Commands.Television
{
    public class TurnTelevisionOff : ICommand
    {
        private ISoundDevice soundDevice;
        public TurnTelevisionOff(ISoundDevice newSoundDevice)
        {
            soundDevice = newSoundDevice;
        }
        public string Execute()
        {
            return soundDevice.TurnOff();
        }
    }
}
