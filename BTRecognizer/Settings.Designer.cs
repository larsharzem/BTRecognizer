namespace BTRecognizer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.saveFilePosition_input = new System.Windows.Forms.TextBox();
            this.savedFileButton = new System.Windows.Forms.Button();
            this.savedFileBrowse = new System.Windows.Forms.OpenFileDialog();
            this.save_button = new System.Windows.Forms.Button();
            this.saveFile_grp = new System.Windows.Forms.GroupBox();
            this.refreshInterval_grp = new System.Windows.Forms.GroupBox();
            this.refreshInterval_input = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.editingPassword_grp = new System.Windows.Forms.GroupBox();
            this.editingPassword_input = new System.Windows.Forms.TextBox();
            this.updateFailedMessage_checkbox = new System.Windows.Forms.CheckBox();
            this.timeToLive_grp = new System.Windows.Forms.GroupBox();
            this.timeToLive_input = new System.Windows.Forms.ListBox();
            this.saveFile_grp.SuspendLayout();
            this.refreshInterval_grp.SuspendLayout();
            this.panel1.SuspendLayout();
            this.editingPassword_grp.SuspendLayout();
            this.timeToLive_grp.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveFilePosition_input
            // 
            this.saveFilePosition_input.Location = new System.Drawing.Point(6, 19);
            this.saveFilePosition_input.Name = "saveFilePosition_input";
            this.saveFilePosition_input.Size = new System.Drawing.Size(288, 20);
            this.saveFilePosition_input.TabIndex = 1;
            // 
            // savedFileButton
            // 
            this.savedFileButton.Location = new System.Drawing.Point(221, 45);
            this.savedFileButton.Name = "savedFileButton";
            this.savedFileButton.Size = new System.Drawing.Size(73, 21);
            this.savedFileButton.TabIndex = 2;
            this.savedFileButton.Text = "Browse";
            this.savedFileButton.UseVisualStyleBackColor = true;
            this.savedFileButton.Click += new System.EventHandler(this.savedFileButton_Click);
            // 
            // savedFileBrowse
            // 
            this.savedFileBrowse.FileName = "savedDevices.xml";
            this.savedFileBrowse.Filter = "XML Files|*.xml|All Files|*.*";
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(257, 302);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(67, 21);
            this.save_button.TabIndex = 3;
            this.save_button.Text = "Save";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_Click);
            // 
            // saveFile_grp
            // 
            this.saveFile_grp.Controls.Add(this.saveFilePosition_input);
            this.saveFile_grp.Controls.Add(this.savedFileButton);
            this.saveFile_grp.Location = new System.Drawing.Point(3, 3);
            this.saveFile_grp.Name = "saveFile_grp";
            this.saveFile_grp.Size = new System.Drawing.Size(300, 72);
            this.saveFile_grp.TabIndex = 5;
            this.saveFile_grp.TabStop = false;
            this.saveFile_grp.Text = "Store devices in file";
            // 
            // refreshInterval_grp
            // 
            this.refreshInterval_grp.Controls.Add(this.refreshInterval_input);
            this.refreshInterval_grp.Location = new System.Drawing.Point(3, 81);
            this.refreshInterval_grp.Name = "refreshInterval_grp";
            this.refreshInterval_grp.Size = new System.Drawing.Size(130, 122);
            this.refreshInterval_grp.TabIndex = 6;
            this.refreshInterval_grp.TabStop = false;
            this.refreshInterval_grp.Text = "Device refresh interval";
            // 
            // refreshInterval_input
            // 
            this.refreshInterval_input.FormattingEnabled = true;
            this.refreshInterval_input.Items.AddRange(new object[] {
            "5 seconds",
            "10 seconds",
            "15 seconds",
            "20 seconds",
            "30 seconds",
            "60 seconds",
            "120 seconds"});
            this.refreshInterval_input.Location = new System.Drawing.Point(6, 19);
            this.refreshInterval_input.Name = "refreshInterval_input";
            this.refreshInterval_input.Size = new System.Drawing.Size(116, 95);
            this.refreshInterval_input.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.editingPassword_grp);
            this.panel1.Controls.Add(this.updateFailedMessage_checkbox);
            this.panel1.Controls.Add(this.timeToLive_grp);
            this.panel1.Controls.Add(this.refreshInterval_grp);
            this.panel1.Controls.Add(this.saveFile_grp);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(312, 284);
            this.panel1.TabIndex = 7;
            // 
            // editingPassword_grp
            // 
            this.editingPassword_grp.Controls.Add(this.editingPassword_input);
            this.editingPassword_grp.Location = new System.Drawing.Point(9, 209);
            this.editingPassword_grp.Name = "editingPassword_grp";
            this.editingPassword_grp.Size = new System.Drawing.Size(288, 47);
            this.editingPassword_grp.TabIndex = 9;
            this.editingPassword_grp.TabStop = false;
            this.editingPassword_grp.Text = "Password for editing the known devices";
            // 
            // editingPassword_input
            // 
            this.editingPassword_input.Location = new System.Drawing.Point(6, 19);
            this.editingPassword_input.Name = "editingPassword_input";
            this.editingPassword_input.PasswordChar = '*';
            this.editingPassword_input.Size = new System.Drawing.Size(276, 20);
            this.editingPassword_input.TabIndex = 0;
            this.editingPassword_input.UseSystemPasswordChar = true;
            // 
            // updateFailedMessage_checkbox
            // 
            this.updateFailedMessage_checkbox.AutoSize = true;
            this.updateFailedMessage_checkbox.Location = new System.Drawing.Point(9, 262);
            this.updateFailedMessage_checkbox.Name = "updateFailedMessage_checkbox";
            this.updateFailedMessage_checkbox.Size = new System.Drawing.Size(247, 17);
            this.updateFailedMessage_checkbox.TabIndex = 8;
            this.updateFailedMessage_checkbox.Text = "Show Message if the Online Update has failed.";
            this.updateFailedMessage_checkbox.UseVisualStyleBackColor = true;
            this.updateFailedMessage_checkbox.CheckedChanged += new System.EventHandler(this.updateFailedMessage_checkbox_CheckedChanged);
            // 
            // timeToLive_grp
            // 
            this.timeToLive_grp.Controls.Add(this.timeToLive_input);
            this.timeToLive_grp.Location = new System.Drawing.Point(139, 81);
            this.timeToLive_grp.Name = "timeToLive_grp";
            this.timeToLive_grp.Size = new System.Drawing.Size(164, 122);
            this.timeToLive_grp.TabIndex = 7;
            this.timeToLive_grp.TabStop = false;
            this.timeToLive_grp.Text = "Time to live for online devices";
            // 
            // timeToLive_input
            // 
            this.timeToLive_input.FormattingEnabled = true;
            this.timeToLive_input.Items.AddRange(new object[] {
            "1 minute(s)",
            "2 minute(s)",
            "3 minute(s)",
            "5 minute(s)",
            "7 minute(s)",
            "10 minute(s)",
            "15 minute(s)"});
            this.timeToLive_input.Location = new System.Drawing.Point(6, 19);
            this.timeToLive_input.Name = "timeToLive_input";
            this.timeToLive_input.Size = new System.Drawing.Size(152, 95);
            this.timeToLive_input.TabIndex = 0;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 331);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.save_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Settings";
            this.ShowInTaskbar = false;
            this.Text = "Settings";
            this.TopMost = true;
            this.saveFile_grp.ResumeLayout(false);
            this.saveFile_grp.PerformLayout();
            this.refreshInterval_grp.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.editingPassword_grp.ResumeLayout(false);
            this.editingPassword_grp.PerformLayout();
            this.timeToLive_grp.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox saveFilePosition_input;
        private System.Windows.Forms.Button savedFileButton;
        private System.Windows.Forms.OpenFileDialog savedFileBrowse;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.GroupBox saveFile_grp;
        private System.Windows.Forms.GroupBox refreshInterval_grp;
        private System.Windows.Forms.ListBox refreshInterval_input;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox timeToLive_grp;
        private System.Windows.Forms.ListBox timeToLive_input;
        private System.Windows.Forms.CheckBox updateFailedMessage_checkbox;
        private System.Windows.Forms.GroupBox editingPassword_grp;
        private System.Windows.Forms.TextBox editingPassword_input;
    }
}