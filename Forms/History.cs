using ElevenLabs.History;
using NAudio.Gui;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleElevenlabs
{
    public partial class History : Form
    {
        public History()
        {
            InitializeComponent();
            Get_History_Items();
        }

        public async void Get_History_Items()
        {
            var historyItems = await Manager.Configs.Api.HistoryEndpoint.GetHistoryAsync();
            foreach (var historyItem in historyItems.OrderBy(historyItem => historyItem.Date))
            {
                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                row.Cells[0].Value = historyItem.VoiceName;
                row.Cells[1].Value = historyItem.Text;
                row.Cells[2].Value = historyItem;

                /*Button play = new Button();
                //play.Text = "play";
                //play.Name = "play";
                row.Cells[3].Value = play;
                Button download = new Button();
                download.Text = "download";
                download.Name = "download";
                row.Cells[4].Value = download;*/
                dataGridView1.Rows.Add(row);
            }
        }

        public async void Play_Message(HistoryItem historyItem)
        {
            string clippath = await Manager.Configs.Api.HistoryEndpoint.GetHistoryAudioAsync(historyItem);
            var reader = new Mp3FileReader(clippath);
            //WaveFileReader waveReader = new NAudio.Wave.WaveFileReader(clippath);
            Manager.Configs.WaveOut.Init(reader);
            Manager.Configs.WaveOut.Play();
        }

        public async void Download_Message(HistoryItem historyItem)
        {
            await Manager.Configs.Api.HistoryEndpoint.GetHistoryAudioAsync(historyItem);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (e.ColumnIndex == dataGridView1.Columns["Play"].Index)
                {
                    Play_Message((HistoryItem)dataGridView1.Rows[e.RowIndex].Cells[2].Value);
                }
                if (e.ColumnIndex == dataGridView1.Columns["Download"].Index)
                {
                    Download_Message((HistoryItem)dataGridView1.Rows[e.RowIndex].Cells[2].Value);
                }
            }
            catch { }
        }

    }
}
