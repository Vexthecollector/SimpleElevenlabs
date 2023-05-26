using NAudio.Gui;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace SimpleElevenlabs
{
    public partial class Dashboard : Form
    {
        List<String> oldMessages = new List<string>();
        int currentMessage = 0;
        public Dashboard()
        {
            InitializeComponent();
        }

        public string Get_Older_Message()
        {
            try
            {

            int number=oldMessages.Count();
            if(currentMessage>0&&currentMessage<=number)
            {
                currentMessage--;
                string text = oldMessages[currentMessage];
                return text;
            }
            else
            {
                return null;
            }
            }
            catch {
                return null; }
        }

        public string Get_Newer_Message()
        {
            try
            {

            int number = oldMessages.Count();
            if (currentMessage >= 0 && currentMessage <number)
            {
                string text = oldMessages[currentMessage];
                currentMessage++;
                return text;
            }
            else
            {
                return null;
            }
            }
            catch {
                return null; }
        }

        public async void Send_Message()
        {
            String text = messageBox.Text;
            if(!String.IsNullOrEmpty(text)) oldMessages.Add(text);
            var defaultVoiceSettings = await Manager.Configs.Api.VoicesEndpoint.GetDefaultVoiceSettingsAsync();
            string clippath = await Manager.Configs.Api.TextToSpeechEndpoint.TextToSpeechAsync(text, Manager.Configs.Voice, defaultVoiceSettings);
            var reader = new Mp3FileReader(clippath);
            //WaveFileReader waveReader = new NAudio.Wave.WaveFileReader(clippath);
            Manager.Configs.WaveOut.Volume = volumeSlider1.Volume;
            Manager.Configs.WaveOut.Init(reader);
            Manager.Configs.WaveOut.Play();
            messageBox.Clear();
            currentMessage = oldMessages.Count();
        }

        private void sendMessage_Click_1(object sender, EventArgs e)
        {
            Send_Message();
           
        }

        private void messageBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Send_Message();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            if(e.KeyCode == Keys.Up) {
                messageBox.Text=Get_Older_Message();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                messageBox.Text = Get_Newer_Message();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}
