using SoundDevices;
using System;

namespace Commands.Television
{
    public class TurnTelevisionOn : ICommand
    {
        private ISoundDevice soundDevice;
        public TurnTelevisionOn(ISoundDevice newSoundDevice)
        {
            soundDevice = newSoundDevice;
        }
        public string Execute()
        {
           return soundDevice.TurnOn();
        }
    }
}
