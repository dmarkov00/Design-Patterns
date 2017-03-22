using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Commands;
using Commands.Television;
using Commands.Speakers;
using SoundDevices;
using SoundDeviceRemotes;
namespace Tests
{
    [TestClass]

    public class CommandPatternTests
    {
        private ISoundDevice soundDevice;
        private ICommand command;
        [TestMethod]
        public void TurnTelevisionOn()
        {
            soundDevice = TelevisionRemote.GetSoundDevice();
            //command = new TurnTelevisionOn(soundDevice);

            string result = command.Execute();
            Assert.AreEqual("The TELEVISION is ON", result);
        }
    }
}
