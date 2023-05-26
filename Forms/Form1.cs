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
                LoadDashBoard();
            }
            else
            {
                MessageBox.Show("No Api Key set yet, please set one in the settings");
                LoadSettings();
            }

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





        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
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
            LoadSettings();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            LoadDashBoard();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            LoadHistory();
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

        private void LoadSettings()
        {
            labelTitle.Text = "Settings";
            this.formLoader.Controls.Clear();
            Settings settings = new Settings() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            settings.FormBorderStyle = FormBorderStyle.None;
            this.formLoader.Controls.Add(settings);
            settings.Show();
        }

        private void LoadHistory()
        {
            labelTitle.Text = "History";
            this.formLoader.Controls.Clear();
            History history = new History() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            history.FormBorderStyle = FormBorderStyle.None;
            this.formLoader.Controls.Add(history);
            history.Show();
        }

        private void comboBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {

            }
            else
            {

                comboBox2.DroppedDown = true;
                comboBox2.Items.Clear();
                foreach (ElevenLabs.Voices.Voice voice in Manager.Configs.AllVoices)
                {
                    if (voice.Name.ToLower().Contains(comboBox2.Text.ToLower()) || String.IsNullOrEmpty(comboBox2.Text))
                    {

                        comboBox2.Items.Add(new selectedVoice(voice.Id, voice.Name));
                    }
                }
            }
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
