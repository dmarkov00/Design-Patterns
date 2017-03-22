using SoundDevices;
using System;
using System.Windows.Forms;
using Commands.Television;
using Commands.Speakers;
using Commands;
using SoundDeviceRemotes;

namespace Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // TV remote buttons handling
            OnTVRemoteBtn.Click += TVRemoteHandler;
            OffTVRemoteBtn.Click += TVRemoteHandler;
            VolumeUpTVRemoteBtn.Click += TVRemoteHandler;
            VolumeDownTVRemoteBtn.Click += TVRemoteHandler;

            // Speakers remote buttons handling
            OnSpeakersRemoteBtn.Click += SpeakersRemoteHandler;
            OffSpeakersRemoteBtn.Click += SpeakersRemoteHandler;
            VolumeUpSpeakersRemoteBtn.Click += SpeakersRemoteHandler;
            VolumeDownSpeakersRemoteBtn.Click += SpeakersRemoteHandler;

        }
        private ISoundDevice television = TelevisionRemote.GetSoundDevice();
        private ISoundDevice speakers = SpeakersRemote.GetSoundDevice();

        private ICommand command;
        string deviceFeedback = "";

        private void TVRemoteHandler(object sender, EventArgs e)
        {
            string clickedButtonName = ((Button)sender).Name;

            switch (clickedButtonName)
            {
                case "OnTVRemoteBtn":
                    command = new TurnTelevisionOn(television);
                    deviceFeedback = command.Execute();
                    break;
                case "OffTVRemoteBtn":
                    command = new TurnTelevisionOff(television);
                    deviceFeedback = command.Execute();
                    break;
                case "VolumeUpTVRemoteBtn":
                    command = new TurnTelevisionVolumeUp(television);
                    deviceFeedback = command.Execute();
                    break;
                case "VolumeDownTVRemoteBtn":
                    command = new TurnTelevisionVolumeDown(television);
                    deviceFeedback = command.Execute();
                    break;
            }
            listBox1.Items.Add(deviceFeedback);
        }

        private void SpeakersRemoteHandler(object sender, EventArgs e)
        {

            string clickedButtonName = ((Button)sender).Name;
            switch (clickedButtonName)
            {
                case "OnSpeakersRemoteBtn":
                    command = new TurnSpeakersOn(speakers);
                    deviceFeedback = command.Execute();
                    break;
                case "OffSpeakersRemoteBtn":
                    command = new TurnSpeakersOff(speakers);
                    deviceFeedback = command.Execute();
                    break;

                case "VolumeUpSpeakersRemoteBtn":
                    command = new TurnSpeakersVolumeUp(speakers);
                    deviceFeedback = command.Execute();
                    break;
                case "VolumeDownSpeakersRemoteBtn":
                    command = new TurnSpeakersVolumeDown(speakers);
                    deviceFeedback = command.Execute();
                    break;
            }
            listBox1.Items.Add(deviceFeedback);
        }

    }
}
