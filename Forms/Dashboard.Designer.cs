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
            messageBox.Location = new System.Drawing.Point(13, 50);
            messageBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            messageBox.Multiline = true;
            messageBox.Name = "messageBox";
            messageBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            messageBox.Size = new System.Drawing.Size(706, 20);
            messageBox.TabIndex = 11;
            messageBox.KeyDown += messageBox_KeyDown;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(46, 51, 73);
            ClientSize = new System.Drawing.Size(732, 361);
            Controls.Add(sendMessage);
            Controls.Add(volumeSlider1);
            Controls.Add(messageBox);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "Dashboard";
            Text = "Dashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button sendMessage;
        private NAudio.Gui.VolumeSlider volumeSlider1;
        private System.Windows.Forms.TextBox messageBox;
    }
}