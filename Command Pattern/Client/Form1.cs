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

        private ICommand tvCommand;
        private ICommand speakersCommand;

        string deviceFeedback = "";

        // Handlers for executing buttons
        private void BtnExecuteTVCommand_Click(object sender, EventArgs e)
        {
            if(tvCommand != null)
            {
                // Execute command and also assign result 
                deviceFeedback = tvCommand.Execute();

                listBox1.Items.Add(deviceFeedback);
            }         
        }
        private void BtnExecuteSpeakersCommand_Click(object sender, EventArgs e)
        {
            if(speakersCommand != null)
            {
                // Execute command and also assign result 
                deviceFeedback = speakersCommand.Execute();

                listBox1.Items.Add(deviceFeedback);
            }
            
        }

        // TV radio buttons handlers
        private void OnTvRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                tvCommand = new TurnTelevisionOn(television);
            }
        }
        private void OffTvRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                tvCommand = new TurnTelevisionOff(television);
            }
        }
        private void VolumeUpTvRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                tvCommand = new TurnTelevisionVolumeUp(television);
            }
        }
        private void VolumeDownTVRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                tvCommand = new TurnTelevisionVolumeDown(television);
            }
        }

        // Speakers radio buttons handlers
        private void OnSpeakersRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                speakersCommand = new TurnSpeakersOn(speakers);
            }
        }
        private void OffSpeakersRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                speakersCommand = new TurnSpeakersOff(speakers);
            }
        }
        private void VolumeUpSpeakersRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                speakersCommand = new TurnSpeakersVolumeUp(speakers);
            }
        }
        private void VolumeDownSpeakersRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked)
            {
                speakersCommand = new TurnSpeakersVolumeDown(speakers);
            }
        }
    }
}
