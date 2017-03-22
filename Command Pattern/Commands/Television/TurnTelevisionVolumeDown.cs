using SoundDevices;

namespace Commands.Television
{
    public class TurnTelevisionVolumeDown : ICommand
    {
        private ISoundDevice soundDevice;
        public TurnTelevisionVolumeDown(ISoundDevice newSoundDevice)
        {
            soundDevice = newSoundDevice;
        }
        public string Execute()
        {
            return soundDevice.VolumeDown();
        }
    }
}
