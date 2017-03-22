using SoundDevices;

namespace SoundDeviceRemotes
{
    public class TelevisionRemote
    {
        public static ISoundDevice GetSoundDevice()
        {
            return new Television();
        }
    }
}
