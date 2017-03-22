namespace SoundDevices
{
    public interface ISoundDevice
    {
        string TurnOn();
        string TurnOff();
        string VolumeUp();
        string VolumeDown();
    }
}
