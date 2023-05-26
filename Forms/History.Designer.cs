namespace SimpleElevenlabs
{
    partial class History
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
            dataGridView1 = new System.Windows.Forms.DataGridView();
            Voice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Text = new System.Windows.Forms.DataGridViewTextBoxColumn();
            HiddenHistoryItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            Play = new System.Windows.Forms.DataGridViewButtonColumn();
            Download = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { Voice, Text, HiddenHistoryItem, Play, Download });
            dataGridView1.Location = new System.Drawing.Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new System.Drawing.Size(708, 337);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // Voice
            // 
            Voice.HeaderText = "Voice";
            Voice.MinimumWidth = 100;
            Voice.Name = "Voice";
            Voice.Width = 150;
            // 
            // Text
            // 
            Text.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            Text.HeaderText = "Text";
            Text.Name = "Text";
            // 
            // HiddenHistoryItem
            // 
            HiddenHistoryItem.HeaderText = "HiddenHistoryItem";
            HiddenHistoryItem.Name = "HiddenHistoryItem";
            HiddenHistoryItem.Visible = false;
            // 
            // Play
            // 
            Play.HeaderText = "Play";
            Play.MinimumWidth = 50;
            Play.Name = "Play";
            Play.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            Play.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            Play.Text = "Play";
            Play.UseColumnTextForButtonValue = true;
            Play.Width = 50;
            // 
            // Download
            // 
            Download.HeaderText = "Download";
            Download.Name = "Download";
            Download.Text = "Download";
            Download.UseColumnTextForButtonValue = true;
            // 
            // History
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(46, 51, 73);
            ClientSize = new System.Drawing.Size(732, 361);
            Controls.Add(dataGridView1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "History";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Voice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Text;
        private System.Windows.Forms.DataGridViewTextBoxColumn HiddenHistoryItem;
        private System.Windows.Forms.DataGridViewButtonColumn Play;
        private System.Windows.Forms.DataGridViewButtonColumn Download;
    }
}