using ElevenLabs;
using Microsoft.VisualBasic.Logging;
using NAudio.Gui;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
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
        int boxHeight = 20;
        public Dashboard()
        {
            InitializeComponent();
            Manager.Configs.Dashboard = this;
            boxHeight = messageBox.Height;
            Set_Models_List();
            Set_Voice_Settings();
        }

        public string Get_Older_Message()
        {
            try
            {

                int number = oldMessages.Count();
                if (currentMessage > 0 && currentMessage <= number)
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
            catch
            {
                return null;
            }
        }

        public void Set_Models_List()
        {
            foreach (ElevenLabs.Models.Model model in Manager.Configs.Models)
            {
                audioModel.Items.Add(new selectedModel(model.Id, model.Name));
            }
            audioModel.SelectedIndex = 0;
        }

        public string Get_Newer_Message()
        {
            try
            {

                int number = oldMessages.Count();
                if (currentMessage >= 0 && currentMessage < number)
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
            catch
            {
                return null;
            }
        }

        public async void Send_Message()
        {
            String text = messageBox.Text;
            if (!String.IsNullOrEmpty(text)) oldMessages.Add(text);
            ElevenLabs.Voices.VoiceSettings defaultVoiceSettings = await Manager.Configs.Api.VoicesEndpoint.GetDefaultVoiceSettingsAsync();
            Get_Voice_Settings(ref defaultVoiceSettings);
            string clippath = await Manager.Configs.Api.TextToSpeechEndpoint.TextToSpeechAsync(text, Manager.Configs.Voice, defaultVoiceSettings, model: Manager.Configs.Model, deleteCachedFile: true);
            Play_Message(clippath);
        }

        public async void Play_Message(string clippath)
        {
            var reader = new Mp3FileReader(clippath);
            //WaveFileReader waveReader = new NAudio.Wave.WaveFileReader(clippath);
            Manager.Configs.WaveOut.Volume = volumeSlider1.Volume;
            Manager.Configs.WaveOut.Init(reader);
            Manager.Configs.WaveOut.Play();
            messageBox.Clear();
            currentMessage = oldMessages.Count();
            while (Manager.Configs.WaveOut.PlaybackState == NAudio.Wave.PlaybackState.Playing)
            {
                System.Threading.Thread.Sleep(100);
            }
            reader.Close();
        }

        private void sendMessage_Click_1(object sender, EventArgs e)
        {
            Send_Message();

        }

        private void messageBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Send_Message();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.Up)
            {
                messageBox.Text = Get_Older_Message();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                messageBox.Text = Get_Newer_Message();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            if (TextRenderer.MeasureText(messageBox.Text, messageBox.Font).Width > messageBox.Width - 30)
            {
                //MessageBox.Show(TextRenderer.MeasureText(messageBox.Text, messageBox.Font).Width.ToString());
                messageBox.Height = Math.Max((((TextRenderer.MeasureText(messageBox.Text, messageBox.Font).Width / (messageBox.Width - 30)) + 1) * boxHeight), boxHeight);
            }
            else
            {
                messageBox.Height = boxHeight;
            }
        }

        public void set_Model(string id)
        {
            foreach (var model in Manager.Configs.Models)
            {
                if (model.Id == id)
                {
                    Manager.Configs.Model = model;
                    break;
                }
            }
        }

        private void audioModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            set_Model(((selectedModel)audioModel.SelectedItem).Id);
        }

        public void Set_Voice_Settings()
        {
            try
            {

            ElevenLabs.Voices.VoiceSettings voiceSettings = Manager.Configs.Voice.Settings;
            trackBarClarity.Value = Convert.ToInt32(voiceSettings.SimilarityBoost * 100);
            trackBarStability.Value = Convert.ToInt32(voiceSettings.Stability * 100);
            trackBarStyle.Value = Convert.ToInt32(voiceSettings.Style * 100);
            checkBoxBoost.Checked = voiceSettings.SpeakerBoost;
            } catch (Exception ex)
            {

            }
        }

        public void Get_Voice_Settings(ref ElevenLabs.Voices.VoiceSettings voiceSettings)
        {
            voiceSettings.Stability =trackBarStability.Value/100f;
            voiceSettings.SimilarityBoost = trackBarClarity.Value / 100f;
            voiceSettings.Style = trackBarStyle.Value / 100f;
            voiceSettings.SpeakerBoost = checkBoxBoost.Checked;
        }

    }
    public class selectedModel
    {
        public selectedModel(String id, string name)
        {
            Id = id;
            Name = name;
        }
        public string Id { get; set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
