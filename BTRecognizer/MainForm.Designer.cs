namespace BTRecognizer
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.scanToggle_button = new System.Windows.Forms.Button();
            this.selectedName_input = new System.Windows.Forms.TextBox();
            this.unknownDevices_list = new System.Windows.Forms.ListView();
            this.selectedMac_input = new System.Windows.Forms.TextBox();
            this.knownDevices_list = new System.Windows.Forms.ListView();
            this.add_button = new System.Windows.Forms.Button();
            this.onlineDevices_list = new System.Windows.Forms.ListView();
            this.settings_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.unknownDevices_group = new System.Windows.Forms.GroupBox();
            this.pin_label = new System.Windows.Forms.Label();
            this.pin_input = new System.Windows.Forms.TextBox();
            this.knownDevices_group = new System.Windows.Forms.GroupBox();
            this.onlineDevices_group = new System.Windows.Forms.GroupBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.scanStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.info_button = new System.Windows.Forms.Button();
            this.inSystray_notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.inSystray_menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.show_item = new System.Windows.Forms.ToolStripMenuItem();
            this.close_item = new System.Windows.Forms.ToolStripMenuItem();
            this.unknownDevices_group.SuspendLayout();
            this.knownDevices_group.SuspendLayout();
            this.onlineDevices_group.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.inSystray_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // scanToggle_button
            // 
            this.scanToggle_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scanToggle_button.Location = new System.Drawing.Point(12, 12);
            this.scanToggle_button.Name = "scanToggle_button";
            this.scanToggle_button.Size = new System.Drawing.Size(135, 40);
            this.scanToggle_button.TabIndex = 0;
            this.scanToggle_button.Text = "Disable scanning";
            this.scanToggle_button.UseVisualStyleBackColor = true;
            this.scanToggle_button.Click += new System.EventHandler(this.manScan_Click);
            // 
            // selectedName_input
            // 
            this.selectedName_input.Location = new System.Drawing.Point(100, 256);
            this.selectedName_input.Name = "selectedName_input";
            this.selectedName_input.Size = new System.Drawing.Size(162, 20);
            this.selectedName_input.TabIndex = 4;
            // 
            // unknownDevices_list
            // 
            this.unknownDevices_list.Location = new System.Drawing.Point(6, 19);
            this.unknownDevices_list.Name = "unknownDevices_list";
            this.unknownDevices_list.Size = new System.Drawing.Size(256, 231);
            this.unknownDevices_list.TabIndex = 6;
            this.unknownDevices_list.UseCompatibleStateImageBehavior = false;
            // 
            // selectedMac_input
            // 
            this.selectedMac_input.Location = new System.Drawing.Point(6, 256);
            this.selectedMac_input.MaxLength = 12;
            this.selectedMac_input.Name = "selectedMac_input";
            this.selectedMac_input.Size = new System.Drawing.Size(90, 20);
            this.selectedMac_input.TabIndex = 8;
            // 
            // knownDevices_list
            // 
            this.knownDevices_list.Location = new System.Drawing.Point(6, 19);
            this.knownDevices_list.Name = "knownDevices_list";
            this.knownDevices_list.Size = new System.Drawing.Size(256, 282);
            this.knownDevices_list.TabIndex = 7;
            this.knownDevices_list.UseCompatibleStateImageBehavior = false;
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(125, 308);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(144, 21);
            this.add_button.TabIndex = 10;
            this.add_button.Text = "Add to known devices";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_Click);
            // 
            // onlineDevices_list
            // 
            this.onlineDevices_list.Location = new System.Drawing.Point(6, 20);
            this.onlineDevices_list.Name = "onlineDevices_list";
            this.onlineDevices_list.Size = new System.Drawing.Size(314, 308);
            this.onlineDevices_list.TabIndex = 12;
            this.onlineDevices_list.UseCompatibleStateImageBehavior = false;
            // 
            // settings_button
            // 
            this.settings_button.Location = new System.Drawing.Point(781, 12);
            this.settings_button.Name = "settings_button";
            this.settings_button.Size = new System.Drawing.Size(100, 21);
            this.settings_button.TabIndex = 13;
            this.settings_button.Text = "Settings";
            this.settings_button.UseVisualStyleBackColor = true;
            this.settings_button.Click += new System.EventHandler(this.settings_Click);
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(118, 307);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(144, 21);
            this.delete_button.TabIndex = 14;
            this.delete_button.Text = "Delete from known devices";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_Click);
            // 
            // unknownDevices_group
            // 
            this.unknownDevices_group.Controls.Add(this.pin_label);
            this.unknownDevices_group.Controls.Add(this.pin_input);
            this.unknownDevices_group.Controls.Add(this.unknownDevices_list);
            this.unknownDevices_group.Controls.Add(this.selectedMac_input);
            this.unknownDevices_group.Controls.Add(this.selectedName_input);
            this.unknownDevices_group.Controls.Add(this.add_button);
            this.unknownDevices_group.Location = new System.Drawing.Point(12, 62);
            this.unknownDevices_group.Name = "unknownDevices_group";
            this.unknownDevices_group.Size = new System.Drawing.Size(269, 335);
            this.unknownDevices_group.TabIndex = 15;
            this.unknownDevices_group.TabStop = false;
            this.unknownDevices_group.Text = "Unknown Devices";
            // 
            // pin_label
            // 
            this.pin_label.AutoSize = true;
            this.pin_label.Location = new System.Drawing.Point(112, 285);
            this.pin_label.Name = "pin_label";
            this.pin_label.Size = new System.Drawing.Size(113, 13);
            this.pin_label.TabIndex = 12;
            this.pin_label.Text = "PIN for authentication:";
            // 
            // pin_input
            // 
            this.pin_input.Location = new System.Drawing.Point(231, 282);
            this.pin_input.MaxLength = 4;
            this.pin_input.Name = "pin_input";
            this.pin_input.Size = new System.Drawing.Size(31, 20);
            this.pin_input.TabIndex = 11;
            this.pin_input.Text = "0000";
            // 
            // knownDevices_group
            // 
            this.knownDevices_group.Controls.Add(this.knownDevices_list);
            this.knownDevices_group.Controls.Add(this.delete_button);
            this.knownDevices_group.Location = new System.Drawing.Point(287, 62);
            this.knownDevices_group.Name = "knownDevices_group";
            this.knownDevices_group.Size = new System.Drawing.Size(268, 335);
            this.knownDevices_group.TabIndex = 16;
            this.knownDevices_group.TabStop = false;
            this.knownDevices_group.Text = "Known Devices";
            // 
            // onlineDevices_group
            // 
            this.onlineDevices_group.Controls.Add(this.onlineDevices_list);
            this.onlineDevices_group.Location = new System.Drawing.Point(561, 62);
            this.onlineDevices_group.Name = "onlineDevices_group";
            this.onlineDevices_group.Size = new System.Drawing.Size(326, 335);
            this.onlineDevices_group.TabIndex = 17;
            this.onlineDevices_group.TabStop = false;
            this.onlineDevices_group.Text = "Known and online Devices";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scanStatus});
            this.statusStrip.Location = new System.Drawing.Point(0, 406);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(898, 22);
            this.statusStrip.TabIndex = 18;
            this.statusStrip.Text = "statusStrip1";
            // 
            // scanStatus
            // 
            this.scanStatus.AutoSize = false;
            this.scanStatus.Name = "scanStatus";
            this.scanStatus.Size = new System.Drawing.Size(500, 17);
            this.scanStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // info_button
            // 
            this.info_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.info_button.Location = new System.Drawing.Point(425, 12);
            this.info_button.Name = "info_button";
            this.info_button.Size = new System.Drawing.Size(59, 21);
            this.info_button.TabIndex = 19;
            this.info_button.Text = "Info";
            this.info_button.UseVisualStyleBackColor = true;
            this.info_button.Click += new System.EventHandler(this.info_button_Click);
            // 
            // inSystray_notifyIcon
            // 
            this.inSystray_notifyIcon.ContextMenuStrip = this.inSystray_menu;
            this.inSystray_notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("inSystray_notifyIcon.Icon")));
            this.inSystray_notifyIcon.Text = "BluetoothRecognizer";
            this.inSystray_notifyIcon.Visible = true;
            this.inSystray_notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.toSystray_MouseDoubleClick);
            // 
            // inSystray_menu
            // 
            this.inSystray_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.show_item,
            this.close_item});
            this.inSystray_menu.Name = "inSystray_menu";
            this.inSystray_menu.Size = new System.Drawing.Size(104, 48);
            // 
            // show_item
            // 
            this.show_item.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.show_item.Name = "show_item";
            this.show_item.Size = new System.Drawing.Size(103, 22);
            this.show_item.Text = "Show";
            this.show_item.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.show_item.Click += new System.EventHandler(this.show_item_Click);
            // 
            // close_item
            // 
            this.close_item.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.close_item.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.close_item.Name = "close_item";
            this.close_item.Size = new System.Drawing.Size(103, 22);
            this.close_item.Text = "Close";
            this.close_item.Click += new System.EventHandler(this.close_item_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 428);
            this.Controls.Add(this.info_button);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.onlineDevices_group);
            this.Controls.Add(this.knownDevices_group);
            this.Controls.Add(this.unknownDevices_group);
            this.Controls.Add(this.settings_button);
            this.Controls.Add(this.scanToggle_button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "BluetoothRecognizer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Resize += new System.EventHandler(this.minimize_Click);
            this.unknownDevices_group.ResumeLayout(false);
            this.unknownDevices_group.PerformLayout();
            this.knownDevices_group.ResumeLayout(false);
            this.onlineDevices_group.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.inSystray_menu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button scanToggle_button;
        private System.Windows.Forms.TextBox selectedName_input;
        private System.Windows.Forms.ListView unknownDevices_list;
        private System.Windows.Forms.TextBox selectedMac_input;
        private System.Windows.Forms.ListView knownDevices_list;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.ListView onlineDevices_list;
        private System.Windows.Forms.Button settings_button;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.GroupBox unknownDevices_group;
        private System.Windows.Forms.GroupBox knownDevices_group;
        private System.Windows.Forms.GroupBox onlineDevices_group;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel scanStatus;
        private System.Windows.Forms.TextBox pin_input;
        private System.Windows.Forms.Label pin_label;
        private System.Windows.Forms.Button info_button;
        private System.Windows.Forms.NotifyIcon inSystray_notifyIcon;
        private System.Windows.Forms.ContextMenuStrip inSystray_menu;
        private System.Windows.Forms.ToolStripMenuItem show_item;
        private System.Windows.Forms.ToolStripMenuItem close_item;
    }
}

