using ElevenLabs;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleElevenlabs
{
    public partial class Settings : Form
    {
        Utils utils=new Utils();
        public Settings()
        {
            InitializeComponent();
            Manager.Configs.Settings = this;
            get_Audio_Devices();
            Try_Get_Api_Key();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            utils.set_Audio_Device(comboBox1.SelectedIndex);
        }

        private void Try_Get_Api_Key()
        {
            try
            {

            apiKeyBox.Text = Manager.Configs.Api.ElevenLabsAuthentication.ApiKey;
            }
            catch { }
        }

        private void setApiKey_Click(object sender, EventArgs e)
        {
            utils.Initialize(apiKeyBox.Text);
            if (MessageBox.Show("Would you like to save the key for future use?", "Save Key?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                utils.Store_API_Key(apiKeyBox.Text);
            }
        }

        public void get_Audio_Devices()
        {
            int waveOutDevices = Manager.Configs.WaveOutDeviceNumbers;
            for (int waveOutDevice = 0; waveOutDevice < waveOutDevices; waveOutDevice++)
            {
                WaveOutCapabilities deviceInfo = WaveOut.GetCapabilities(waveOutDevice);
                comboBox1.Items.Add(String.Format("Device {0}: {1}", waveOutDevice, deviceInfo.ProductName));
            }
            if (utils.Try_Get_Audio_Device())
            {
                comboBox1.SelectedIndex = Manager.Configs.WaveOut.DeviceNumber;
            }
            else
            {
                comboBox1.SelectedIndex = 0;
            }
        }
    }
}
