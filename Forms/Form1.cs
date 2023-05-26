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
using ElevenLabs.User;

namespace SimpleElevenlabs
{
    public partial class Form1 : Form
    {

        WaveOut waveOut = Manager.Configs.WaveOut;
        Utils utils = new Utils();
        public Form1()
        {
            InitializeComponent();
            Manager.Configs.Form1 = this;
            if (File.Exists(".apikey"))
            {
                try
                {

                    utils.Initialize(File.ReadAllText(".apikey"));

                }
                catch
                {
                    MessageBox.Show("The API Key wasn't properly stored. You will have to set it again.");
                }
                //textBox1.Text = api.ElevenLabsAuthentication.ApiKey;

            }
            LoadDashBoard();
        }

        public void Set_Login()
        {
            userLogin.Text = "Logged In";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            string apikey = "";
            Show_Input_Dialog(ref apikey, "Set API Key");
            utils.Initialize(apikey);
            if (MessageBox.Show("Would you like to save the key for future use?", "Save Key?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                utils.Store_API_Key(apikey);
            }

        }



        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            utils.set_Audio_Device(comboBox1.SelectedIndex);
        }

        private void SendMessage_Click(object sender, EventArgs e)
        {
            sendMessage();
        }

        public async void sendMessage()
        {
            String text = messageBox.Text;
            var defaultVoiceSettings = await Manager.Configs.Api.VoicesEndpoint.GetDefaultVoiceSettingsAsync();
            string clippath = await Manager.Configs.Api.TextToSpeechEndpoint.TextToSpeechAsync(text, Manager.Configs.Voice, defaultVoiceSettings);
            var reader = new Mp3FileReader(clippath);
            //WaveFileReader waveReader = new NAudio.Wave.WaveFileReader(clippath);
            waveOut.Volume = volumeSlider1.Volume;
            waveOut.Init(reader);
            waveOut.Play();
        }

        public async void get_Voices()
        {
            Manager.Configs.AllVoices = (List<ElevenLabs.Voices.Voice>)await Manager.Configs.Api.VoicesEndpoint.GetAllVoicesAsync();
            foreach (ElevenLabs.Voices.Voice voice in Manager.Configs.AllVoices)
            {
                comboBox2.Items.Add(new selectedVoice(voice.Id, voice.Name));
            }
            comboBox2.SelectedIndex = 0;
        }

        public async void set_Voice(string id)
        {
            Manager.Configs.Voice = await Manager.Configs.Api.VoicesEndpoint.GetVoiceAsync(id);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            set_Voice(((selectedVoice)comboBox2.SelectedItem).Id);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            labelTitle.Text = "Settings";
            this.formLoader.Controls.Clear();
            Settings settings = new Settings() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            settings.FormBorderStyle = FormBorderStyle.None;
            this.formLoader.Controls.Add(settings);
            settings.Show();
        }

        private void LoadDashBoard()
        {
            labelTitle.Text = "Dashboard";
            this.formLoader.Controls.Clear();
            Dashboard dashboard = new Dashboard() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            dashboard.FormBorderStyle = FormBorderStyle.None;
            this.formLoader.Controls.Add(dashboard);
            dashboard.Show();
        }



        private static DialogResult Show_Input_Dialog(ref string input, string dialogName = "Name")
        {
            System.Drawing.Size size = new System.Drawing.Size(200, 70);
            Form inputBox = new Form();

            inputBox.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            inputBox.ClientSize = size;
            inputBox.Text = dialogName;

            System.Windows.Forms.TextBox textBox = new TextBox();
            textBox.Size = new System.Drawing.Size(size.Width - 10, 23);
            textBox.Location = new System.Drawing.Point(5, 5);
            textBox.Text = input;
            inputBox.Controls.Add(textBox);

            Button okButton = new Button();
            okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            okButton.Name = "okButton";
            okButton.Size = new System.Drawing.Size(75, 23);
            okButton.Text = "&OK";
            okButton.Location = new System.Drawing.Point(size.Width - 80 - 80, 39);
            inputBox.Controls.Add(okButton);

            Button cancelButton = new Button();
            cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new System.Drawing.Size(75, 23);
            cancelButton.Text = "&Cancel";
            cancelButton.Location = new System.Drawing.Point(size.Width - 80, 39);
            inputBox.Controls.Add(cancelButton);

            inputBox.AcceptButton = okButton;
            inputBox.CancelButton = cancelButton;

            DialogResult result = inputBox.ShowDialog();
            input = textBox.Text;
            return result;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            LoadDashBoard();
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
