namespace SimpleElevenlabs
{
    partial class VoiceForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            addAudio = new System.Windows.Forms.Button();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            voiceListBox = new System.Windows.Forms.ComboBox();
            updateVoice = new System.Windows.Forms.Button();
            Voice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            hiddenUpdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // addAudio
            // 
            addAudio.Location = new System.Drawing.Point(602, 12);
            addAudio.Name = "addAudio";
            addAudio.Size = new System.Drawing.Size(118, 23);
            addAudio.TabIndex = 0;
            addAudio.Text = "Add Audio Sample";
            addAudio.UseVisualStyleBackColor = true;
            addAudio.Click += addAudio_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Voice, hiddenUpdate, Delete });
            dataGridView1.Location = new System.Drawing.Point(12, 81);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new System.Drawing.Size(708, 307);
            dataGridView1.TabIndex = 1;
            // 
            // voiceListBox
            // 
            voiceListBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            voiceListBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            voiceListBox.BackColor = System.Drawing.Color.White;
            voiceListBox.ForeColor = System.Drawing.Color.FromArgb(0, 156, 149);
            voiceListBox.FormattingEnabled = true;
            voiceListBox.Location = new System.Drawing.Point(9, 13);
            voiceListBox.Margin = new System.Windows.Forms.Padding(0);
            voiceListBox.MaxDropDownItems = 30;
            voiceListBox.Name = "voiceListBox";
            voiceListBox.Size = new System.Drawing.Size(187, 23);
            voiceListBox.TabIndex = 9;
            voiceListBox.SelectedIndexChanged += voiceListBox_SelectedIndexChanged;
            // 
            // updateVoice
            // 
            updateVoice.Location = new System.Drawing.Point(602, 52);
            updateVoice.Name = "updateVoice";
            updateVoice.Size = new System.Drawing.Size(118, 23);
            updateVoice.TabIndex = 10;
            updateVoice.Text = "Update Voice";
            updateVoice.UseVisualStyleBackColor = true;
            updateVoice.Click += updateVoice_Click;
            // 
            // Voice
            // 
            Voice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            Voice.HeaderText = "Voice";
            Voice.MinimumWidth = 100;
            Voice.Name = "Voice";
            // 
            // hiddenUpdate
            // 
            hiddenUpdate.HeaderText = "hiddenUpdate";
            hiddenUpdate.Name = "hiddenUpdate";
            hiddenUpdate.Visible = false;
            // 
            // Delete
            // 
            Delete.HeaderText = "";
            Delete.Name = "Delete";
            Delete.Text = "Delete";
            Delete.UseColumnTextForButtonValue = true;
            // 
            // VoiceForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(46, 51, 73);
            ClientSize = new System.Drawing.Size(748, 400);
            Controls.Add(updateVoice);
            Controls.Add(voiceListBox);
            Controls.Add(dataGridView1);
            Controls.Add(addAudio);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "VoiceForm";
            Text = "VoiceForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button addAudio;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox voiceListBox;
        private System.Windows.Forms.Button updateVoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Voice;
        private System.Windows.Forms.DataGridViewTextBoxColumn hiddenUpdate;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}