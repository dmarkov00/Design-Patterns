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
        private ISoundDevice television = TelevisionRemote.GetSoundDevice();
        private ISoundDevice speakers = SpeakersRemote.GetSoundDevice();

        private ICommand command;
        string result = "";
        [TestMethod]
        public void TurnTelevisionOn()
        {
            command = new TurnTelevisionOn(television);
            string result = command.Execute();
            Assert.AreEqual("The TELEVISION is ON", result);
        }
        [TestMethod]
        public void TurnTelevisionVolumeUp_Twice()
        {
            command = new TurnTelevisionVolumeUp(television);
            result = command.Execute();
            result = command.Execute();

            Assert.AreEqual("The volume of the TELEVISION is turned UP to 2", result);
        }
        [TestMethod]
        public void TurnSpeakersOff()
        {
            command = new TurnSpeakersOff(speakers);  
            result = command.Execute();

            Assert.AreEqual("The speakers are OFF", result);
        }
        [TestMethod]
        public void TurnSpeakersVolumeDown_3_Times()
        {
            command = new TurnSpeakersVolumeDown(speakers);
            result = command.Execute();
            result = command.Execute();
            result = command.Execute();

            Assert.AreEqual("The volume of the SPEAKERS is turned DOWN to -3", result);
        }
    }
}
