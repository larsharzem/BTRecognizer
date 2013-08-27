namespace BTRecognizer
{
    partial class Password
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Password));
            this.panel1 = new System.Windows.Forms.Panel();
            this.password_grp = new System.Windows.Forms.GroupBox();
            this.password_input = new System.Windows.Forms.TextBox();
            this.password_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.password_grp.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.Controls.Add(this.password_grp);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 83);
            this.panel1.TabIndex = 0;
            // 
            // password_grp
            // 
            this.password_grp.Controls.Add(this.cancel_button);
            this.password_grp.Controls.Add(this.password_button);
            this.password_grp.Controls.Add(this.password_input);
            this.password_grp.Location = new System.Drawing.Point(3, 3);
            this.password_grp.Name = "password_grp";
            this.password_grp.Size = new System.Drawing.Size(254, 72);
            this.password_grp.TabIndex = 0;
            this.password_grp.TabStop = false;
            this.password_grp.Text = "Type in the password";
            // 
            // password_input
            // 
            this.password_input.Location = new System.Drawing.Point(6, 19);
            this.password_input.Name = "password_input";
            this.password_input.Size = new System.Drawing.Size(242, 20);
            this.password_input.TabIndex = 0;
            this.password_input.UseSystemPasswordChar = true;
            // 
            // password_button
            // 
            this.password_button.Location = new System.Drawing.Point(209, 45);
            this.password_button.Name = "password_button";
            this.password_button.Size = new System.Drawing.Size(39, 21);
            this.password_button.TabIndex = 1;
            this.password_button.Text = "OK";
            this.password_button.UseVisualStyleBackColor = true;
            this.password_button.Click += new System.EventHandler(this.password_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(6, 45);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(71, 21);
            this.cancel_button.TabIndex = 2;
            this.cancel_button.Text = "Cancel";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 105);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Password";
            this.Text = "Password";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.password_grp.ResumeLayout(false);
            this.password_grp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox password_grp;
        private System.Windows.Forms.Button password_button;
        private System.Windows.Forms.TextBox password_input;
        private System.Windows.Forms.Button cancel_button;
    }
}