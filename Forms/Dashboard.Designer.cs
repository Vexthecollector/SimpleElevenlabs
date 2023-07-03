namespace SimpleElevenlabs
{
    partial class Dashboard
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
            sendMessage = new System.Windows.Forms.Button();
            volumeSlider1 = new NAudio.Gui.VolumeSlider();
            messageBox = new System.Windows.Forms.TextBox();
            audioModel = new System.Windows.Forms.ComboBox();
            trackBarStability = new System.Windows.Forms.TrackBar();
            trackBarClarity = new System.Windows.Forms.TrackBar();
            trackBarStyle = new System.Windows.Forms.TrackBar();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            checkBoxBoost = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)trackBarStability).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarClarity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBarStyle).BeginInit();
            SuspendLayout();
            // 
            // sendMessage
            // 
            sendMessage.Location = new System.Drawing.Point(13, 12);
            sendMessage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            sendMessage.Name = "sendMessage";
            sendMessage.Size = new System.Drawing.Size(103, 27);
            sendMessage.TabIndex = 12;
            sendMessage.Text = "Send Message";
            sendMessage.UseVisualStyleBackColor = true;
            sendMessage.Click += sendMessage_Click_1;
            // 
            // volumeSlider1
            // 
            volumeSlider1.Location = new System.Drawing.Point(123, 23);
            volumeSlider1.Name = "volumeSlider1";
            volumeSlider1.Size = new System.Drawing.Size(96, 16);
            volumeSlider1.TabIndex = 13;
            // 
            // messageBox
            // 
            messageBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            messageBox.Location = new System.Drawing.Point(12, 45);
            messageBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            messageBox.Multiline = true;
            messageBox.Name = "messageBox";
            messageBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            messageBox.Size = new System.Drawing.Size(706, 20);
            messageBox.TabIndex = 11;
            messageBox.KeyDown += messageBox_KeyDown;
            // 
            // audioModel
            // 
            audioModel.FormattingEnabled = true;
            audioModel.Location = new System.Drawing.Point(245, 16);
            audioModel.Name = "audioModel";
            audioModel.Size = new System.Drawing.Size(202, 23);
            audioModel.TabIndex = 14;
            audioModel.SelectedIndexChanged += audioModel_SelectedIndexChanged;
            // 
            // trackBarStability
            // 
            trackBarStability.Location = new System.Drawing.Point(12, 304);
            trackBarStability.Maximum = 100;
            trackBarStability.Name = "trackBarStability";
            trackBarStability.Size = new System.Drawing.Size(182, 45);
            trackBarStability.TabIndex = 15;
            // 
            // trackBarClarity
            // 
            trackBarClarity.Location = new System.Drawing.Point(265, 304);
            trackBarClarity.Maximum = 100;
            trackBarClarity.Name = "trackBarClarity";
            trackBarClarity.Size = new System.Drawing.Size(182, 45);
            trackBarClarity.TabIndex = 16;
            // 
            // trackBarStyle
            // 
            trackBarStyle.Location = new System.Drawing.Point(538, 304);
            trackBarStyle.Maximum = 100;
            trackBarStyle.Name = "trackBarStyle";
            trackBarStyle.Size = new System.Drawing.Size(182, 45);
            trackBarStyle.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = System.Drawing.SystemColors.Control;
            label1.Location = new System.Drawing.Point(13, 286);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(49, 15);
            label1.TabIndex = 18;
            label1.Text = "Stability";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = System.Drawing.SystemColors.Control;
            label2.Location = new System.Drawing.Point(265, 286);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(104, 15);
            label2.TabIndex = 19;
            label2.Text = "Clarity + Similarity";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = System.Drawing.SystemColors.Control;
            label3.Location = new System.Drawing.Point(538, 286);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(104, 15);
            label3.TabIndex = 20;
            label3.Text = "Style Exaggeration";
            // 
            // checkBoxBoost
            // 
            checkBoxBoost.AutoSize = true;
            checkBoxBoost.ForeColor = System.Drawing.SystemColors.Control;
            checkBoxBoost.Location = new System.Drawing.Point(618, 18);
            checkBoxBoost.Name = "checkBoxBoost";
            checkBoxBoost.Size = new System.Drawing.Size(100, 19);
            checkBoxBoost.TabIndex = 21;
            checkBoxBoost.Text = "Speaker Boost";
            checkBoxBoost.UseVisualStyleBackColor = true;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(46, 51, 73);
            ClientSize = new System.Drawing.Size(732, 361);
            Controls.Add(checkBoxBoost);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(trackBarStyle);
            Controls.Add(trackBarClarity);
            Controls.Add(trackBarStability);
            Controls.Add(audioModel);
            Controls.Add(sendMessage);
            Controls.Add(volumeSlider1);
            Controls.Add(messageBox);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "Dashboard";
            Text = "Dashboard";
            ((System.ComponentModel.ISupportInitialize)trackBarStability).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarClarity).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBarStyle).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button sendMessage;
        private NAudio.Gui.VolumeSlider volumeSlider1;
        private System.Windows.Forms.TextBox messageBox;
        private System.Windows.Forms.ComboBox audioModel;
        private System.Windows.Forms.TrackBar trackBarStability;
        private System.Windows.Forms.TrackBar trackBarClarity;
        private System.Windows.Forms.TrackBar trackBarStyle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxBoost;
    }
}