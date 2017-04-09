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
        }
        private ISoundDevice television = TelevisionRemote.GetSoundDevice();
        private ISoundDevice speakers = SpeakersRemote.GetSoundDevice();

        private ICommand command;
        string deviceFeedback = "";
    
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

        private void BtnExecuteTVCommand_Click(object sender, EventArgs e)
        {
            deviceFeedback = command.Execute();
            listBox1.Items.Add(deviceFeedback);

        }

        private void OnTvRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                command = new TurnTelevisionOn(television);
            }
        }
        private void OffTvRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                command = new TurnTelevisionOff(television);
            }
        }
        private void VolumeUpTvRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                command = new TurnTelevisionVolumeUp(television);
            }
        }
        private void VolumeDownTVRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                command = new TurnTelevisionVolumeDown(television);
            }
        }
    }
}
