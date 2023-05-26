namespace SimpleElevenlabs
{
    partial class Settings
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
            label1 = new System.Windows.Forms.Label();
            setApiKey = new System.Windows.Forms.Button();
            apiKeyBox = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            comboBox1 = new System.Windows.Forms.ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = System.Drawing.Color.FromArgb(0, 126, 249);
            label1.Location = new System.Drawing.Point(443, 15);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(47, 15);
            label1.TabIndex = 8;
            label1.Text = "API Key";
            // 
            // setApiKey
            // 
            setApiKey.Location = new System.Drawing.Point(443, 62);
            setApiKey.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            setApiKey.Name = "setApiKey";
            setApiKey.Size = new System.Drawing.Size(88, 27);
            setApiKey.TabIndex = 7;
            setApiKey.Text = "Set API Key";
            setApiKey.UseVisualStyleBackColor = true;
            setApiKey.Click += setApiKey_Click;
            // 
            // apiKeyBox
            // 
            apiKeyBox.Location = new System.Drawing.Point(443, 33);
            apiKeyBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            apiKeyBox.Name = "apiKeyBox";
            apiKeyBox.Size = new System.Drawing.Size(292, 23);
            apiKeyBox.TabIndex = 6;
            apiKeyBox.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = System.Drawing.Color.FromArgb(0, 126, 249);
            label2.Location = new System.Drawing.Point(443, 107);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(83, 15);
            label2.TabIndex = 10;
            label2.Text = "Output Device";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new System.Drawing.Point(443, 125);
            comboBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(292, 23);
            comboBox1.TabIndex = 9;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // Settings
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(46, 51, 73);
            ClientSize = new System.Drawing.Size(748, 400);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(setApiKey);
            Controls.Add(apiKeyBox);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "Settings";
            Text = "Settings";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button setApiKey;
        private System.Windows.Forms.TextBox apiKeyBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}