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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            comboBox1 = new System.Windows.Forms.ComboBox();
            messageBox = new System.Windows.Forms.TextBox();
            SendMessage = new System.Windows.Forms.Button();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            volumeSlider1 = new NAudio.Gui.VolumeSlider();
            panel1 = new System.Windows.Forms.Panel();
            btnSettings = new System.Windows.Forms.Button();
            userLogin = new System.Windows.Forms.Label();
            comboBox2 = new System.Windows.Forms.ComboBox();
            labelTitle = new System.Windows.Forms.Label();
            formLoader = new System.Windows.Forms.Panel();
            btnDashboard = new System.Windows.Forms.Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new System.Drawing.Point(180, 173);
            comboBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(292, 23);
            comboBox1.TabIndex = 2;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // messageBox
            // 
            messageBox.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            messageBox.Location = new System.Drawing.Point(180, 245);
            messageBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            messageBox.Name = "messageBox";
            messageBox.Size = new System.Drawing.Size(740, 23);
            messageBox.TabIndex = 3;
            // 
            // SendMessage
            // 
            SendMessage.Location = new System.Drawing.Point(180, 274);
            SendMessage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            SendMessage.Name = "SendMessage";
            SendMessage.Size = new System.Drawing.Size(103, 27);
            SendMessage.TabIndex = 4;
            SendMessage.Text = "Send Message";
            SendMessage.UseVisualStyleBackColor = true;
            SendMessage.Click += SendMessage_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = System.Drawing.Color.FromArgb(0, 126, 249);
            label2.Location = new System.Drawing.Point(180, 155);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(83, 15);
            label2.TabIndex = 6;
            label2.Text = "Output Device";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = System.Drawing.Color.FromArgb(0, 126, 249);
            label3.Location = new System.Drawing.Point(8, 107);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(35, 15);
            label3.TabIndex = 7;
            label3.Text = "Voice";
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
            volumeSlider1.Location = new System.Drawing.Point(290, 274);
            volumeSlider1.Name = "volumeSlider1";
            volumeSlider1.Size = new System.Drawing.Size(96, 16);
            volumeSlider1.TabIndex = 10;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(24, 30, 54);
            panel1.Controls.Add(btnDashboard);
            panel1.Controls.Add(btnSettings);
            panel1.Controls.Add(userLogin);
            panel1.Controls.Add(comboBox2);
            panel1.Controls.Add(label3);
            panel1.Dock = System.Windows.Forms.DockStyle.Left;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(173, 519);
            panel1.TabIndex = 11;
            // 
            // btnSettings
            // 
            btnSettings.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSettings.ForeColor = System.Drawing.Color.FromArgb(0, 126, 249);
            btnSettings.Image = (System.Drawing.Image)resources.GetObject("btnSettings.Image");
            btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnSettings.Location = new System.Drawing.Point(8, 484);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new System.Drawing.Size(153, 23);
            btnSettings.TabIndex = 10;
            btnSettings.Text = "Settings";
            btnSettings.UseVisualStyleBackColor = true;
            btnSettings.Click += btnSettings_Click;
            // 
            // userLogin
            // 
            userLogin.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            userLogin.AutoSize = true;
            userLogin.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            userLogin.ForeColor = System.Drawing.Color.FromArgb(0, 126, 249);
            userLogin.Location = new System.Drawing.Point(31, 53);
            userLogin.Name = "userLogin";
            userLogin.Size = new System.Drawing.Size(98, 19);
            userLogin.TabIndex = 9;
            userLogin.Text = "Not Logged In";
            // 
            // comboBox2
            // 
            comboBox2.BackColor = System.Drawing.Color.White;
            comboBox2.ForeColor = System.Drawing.Color.FromArgb(0, 156, 149);
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new System.Drawing.Point(8, 122);
            comboBox2.Margin = new System.Windows.Forms.Padding(0);
            comboBox2.MaxDropDownItems = 30;
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new System.Drawing.Size(152, 23);
            comboBox2.TabIndex = 8;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            labelTitle.Location = new System.Drawing.Point(180, 31);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new System.Drawing.Size(90, 37);
            labelTitle.TabIndex = 12;
            labelTitle.Text = "label5";
            // 
            // formLoader
            // 
            formLoader.BackColor = System.Drawing.Color.FromArgb(46, 51, 73);
            formLoader.Location = new System.Drawing.Point(180, 107);
            formLoader.Name = "formLoader";
            formLoader.Size = new System.Drawing.Size(748, 400);
            formLoader.TabIndex = 13;
            // 
            // btnDashboard
            // 
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnDashboard.ForeColor = System.Drawing.Color.FromArgb(0, 126, 249);
            btnDashboard.Image = (System.Drawing.Image)resources.GetObject("btnDashboard.Image");
            btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnDashboard.Location = new System.Drawing.Point(8, 173);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new System.Drawing.Size(152, 23);
            btnDashboard.TabIndex = 11;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = true;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(46, 51, 73);
            ClientSize = new System.Drawing.Size(933, 519);
            Controls.Add(formLoader);
            Controls.Add(labelTitle);
            Controls.Add(SendMessage);
            Controls.Add(panel1);
            Controls.Add(volumeSlider1);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(messageBox);
            Controls.Add(comboBox1);
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox messageBox;
        private System.Windows.Forms.Button SendMessage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private NAudio.Gui.VolumeSlider volumeSlider1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label userLogin;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel formLoader;
        private System.Windows.Forms.Button btnDashboard;
    }
}

