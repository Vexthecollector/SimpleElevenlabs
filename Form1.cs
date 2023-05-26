using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio;
using NAudio.Wave;
using ElevenLabs;
using System.IO;

namespace SimpleElevenlabs
{
    public partial class Form1 : Form
    {
        WaveOut waveOut = new NAudio.Wave.WaveOut();
        ElevenLabsClient api;
        ElevenLabs.Voices.Voice voice;
        List<ElevenLabs.Voices.Voice> allVoices;
        public Form1()
        {
            InitializeComponent();
            get_Audio_Devices();
            if (File.Exists(".apikey"))
            {
                api = new ElevenLabsClient(File.ReadAllText(".apikey"));
                textBox1.Text = api.ElevenLabsAuthentication.ApiKey;
                get_Voices();

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            api = new ElevenLabsClient(textBox1.Text);
            if (MessageBox.Show("Would you like to save the key for future use?", "Save Key?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                var myFile = File.Create(".apikey");
                myFile.Close();
                File.WriteAllText(".apikey", textBox1.Text);

            }
            get_Voices();

        }

        public void set_Audio_Device(int deviceNumber)
        {

            waveOut.DeviceNumber = deviceNumber;
        }

        public void get_Audio_Devices()
        {

            int waveOutDevices = WaveOut.DeviceCount;
            for (int waveOutDevice = 0; waveOutDevice < waveOutDevices; waveOutDevice++)
            {
                WaveOutCapabilities deviceInfo = WaveOut.GetCapabilities(waveOutDevice);
                comboBox1.Items.Add(String.Format("Device {0}: {1}", waveOutDevice, deviceInfo.ProductName));
            }
            comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            set_Audio_Device(comboBox1.SelectedIndex);
        }

        private void SendMessage_Click(object sender, EventArgs e)
        {
            sendMessage();
        }

        public async void sendMessage()
        {
            String text = messageBox.Text;
            var defaultVoiceSettings = await api.VoicesEndpoint.GetDefaultVoiceSettingsAsync();
            string clippath = await api.TextToSpeechEndpoint.TextToSpeechAsync(text, voice, defaultVoiceSettings);
            var reader = new Mp3FileReader(clippath);
            //WaveFileReader waveReader = new NAudio.Wave.WaveFileReader(clippath);
            waveOut.Volume = volumeSlider1.Volume;
            waveOut.Init(reader);
            waveOut.Play();
        }

        public async void get_Voices()
        {
            allVoices = (List<ElevenLabs.Voices.Voice>)await api.VoicesEndpoint.GetAllVoicesAsync();
            foreach (ElevenLabs.Voices.Voice voice in allVoices)
            {

                comboBox2.Items.Add(new selectedVoice(voice.Id, voice.Name));

            }
            comboBox2.SelectedIndex = 0;
        }

        public async void set_Voice(string id)
        {
            voice = await api.VoicesEndpoint.GetVoiceAsync(id);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            set_Voice(((selectedVoice)comboBox2.SelectedItem).Id);
        }

    }
    public class selectedVoice
    {
        public selectedVoice(string id, string name)
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
