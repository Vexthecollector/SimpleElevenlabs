namespace SimpleElevenlabs
{
    partial class Form1
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
            textBox1 = new System.Windows.Forms.TextBox();
            setApiKey = new System.Windows.Forms.Button();
            comboBox1 = new System.Windows.Forms.ComboBox();
            messageBox = new System.Windows.Forms.TextBox();
            SendMessage = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            comboBox2 = new System.Windows.Forms.ComboBox();
            label4 = new System.Windows.Forms.Label();
            volumeSlider1 = new NAudio.Gui.VolumeSlider();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(13, 38);
            textBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(292, 23);
            textBox1.TabIndex = 0;
            textBox1.UseSystemPasswordChar = true;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // setApiKey
            // 
            setApiKey.Location = new System.Drawing.Point(313, 36);
            setApiKey.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            setApiKey.Name = "setApiKey";
            setApiKey.Size = new System.Drawing.Size(88, 27);
            setApiKey.TabIndex = 1;
            setApiKey.Text = "Set API Key";
            setApiKey.UseVisualStyleBackColor = true;
            setApiKey.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new System.Drawing.Point(13, 173);
            comboBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(292, 23);
            comboBox1.TabIndex = 2;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // messageBox
            // 
            messageBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            messageBox.Location = new System.Drawing.Point(14, 240);
            messageBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            messageBox.Name = "messageBox";
            messageBox.Size = new System.Drawing.Size(905, 23);
            messageBox.TabIndex = 3;
            // 
            // SendMessage
            // 
            SendMessage.Location = new System.Drawing.Point(14, 270);
            SendMessage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            SendMessage.Name = "SendMessage";
            SendMessage.Size = new System.Drawing.Size(103, 27);
            SendMessage.TabIndex = 4;
            SendMessage.Text = "Send Message";
            SendMessage.UseVisualStyleBackColor = true;
            SendMessage.Click += SendMessage_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(14, 16);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(47, 15);
            label1.TabIndex = 5;
            label1.Text = "API Key";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(14, 155);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(83, 15);
            label2.TabIndex = 6;
            label2.Text = "Output Device";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(482, 155);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(35, 15);
            label3.TabIndex = 7;
            label3.Text = "Voice";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new System.Drawing.Point(485, 173);
            comboBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new System.Drawing.Size(292, 23);
            comboBox2.TabIndex = 8;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(15, 222);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(28, 15);
            label4.TabIndex = 9;
            label4.Text = "Text";
            // 
            // volumeSlider1
            // 
            volumeSlider1.Location = new System.Drawing.Point(142, 269);
            volumeSlider1.Name = "volumeSlider1";
            volumeSlider1.Size = new System.Drawing.Size(96, 16);
            volumeSlider1.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(933, 519);
            Controls.Add(volumeSlider1);
            Controls.Add(label4);
            Controls.Add(comboBox2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(SendMessage);
            Controls.Add(messageBox);
            Controls.Add(comboBox1);
            Controls.Add(setApiKey);
            Controls.Add(textBox1);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button setApiKey;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox messageBox;
        private System.Windows.Forms.Button SendMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label4;
        private NAudio.Gui.VolumeSlider volumeSlider1;
    }
}

