using ElevenLabs.History;
using ElevenLabs.Voices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Button = System.Windows.Forms.Button;
using TextBox = System.Windows.Forms.TextBox;

namespace SimpleElevenlabs
{
    public partial class VoiceForm : Form
    {
        List<Voice> voices;
        Voice selectedVoice;
        private OpenFileDialog openFileDialog1 = new OpenFileDialog()
        {
            Filter = "Audio files (*.mp3)|*.mp3|All files (*.*)|*.*",
            Title = "Select audio file",
            RestoreDirectory = true
        };


        public VoiceForm()
        {
            InitializeComponent();
            Initial_List();
        }

        private void addAudio_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var sr = new StreamReader(openFileDialog1.FileName);

                    //SetText(sr.ReadToEnd());
                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }

        }

        private void Populate_List()
        {
            selectedVoice = Manager.Configs.AllVoices.Find(curvoice => voiceListBox.SelectedItem == curvoice.Name);
            try
            {

                dataGridView1.Rows.Clear();
                if (selectedVoice != null && selectedVoice.Samples != null)
                {

                    foreach (Sample voiceItem in selectedVoice.Samples)
                    {


                        DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                        row.Cells[0].Value = voiceItem.FileName;
                        dataGridView1.Rows.Add(row);

                    }
                }
            }
            catch { }
        }

        public void Initial_List()
        {
            try
            {

                voices = Manager.Configs.AllVoices;
                foreach (Voice voice in voices)
                {
                    voiceListBox.Items.Add(voice.Name);
                }
                voiceListBox.SelectedIndex = 0;
            }
            catch { }
            Populate_List();
        }

        private void voiceListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Populate_List();
        }

        private void updateVoice_Click(object sender, EventArgs e)
        {

            Manager.Configs.Api.VoicesEndpoint.EditVoiceAsync(selectedVoice);
        }
    }
}
