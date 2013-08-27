using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using InTheHand.Net;
using InTheHand.Net.Sockets;
using InTheHand.Net.Bluetooth;

namespace BTRecognizer
{
    public partial class MainForm : Form
    {
        private delegate void refreshDelegate();
        private bool closeFromSystray = false;

        public MainForm()
        {
            InitializeComponent();

            unknownDevices_list.View = View.Details;
            unknownDevices_list.FullRowSelect = true;
            unknownDevices_list.Columns.Add("MAC-ID", 90);
            unknownDevices_list.Columns.Add("Name", 162);

            knownDevices_list.View = View.Details;
            knownDevices_list.FullRowSelect = true;
            knownDevices_list.Columns.Add("MAC-ID", 90);
            knownDevices_list.Columns.Add("Name", 162);

            onlineDevices_list.View = View.Details;
            onlineDevices_list.FullRowSelect = true;
            onlineDevices_list.Columns.Add("MAC-ID", 90);
            onlineDevices_list.Columns.Add("Name", 158);
            onlineDevices_list.Columns.Add("Last seen", 62);

            unknownDevices_list.SelectedIndexChanged += new EventHandler(SelectedIndexChanged);

            refreshKnownDevices();

            Program.startScanner();
        }

        void SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedMac_input.Text = unknownDevices_list.FocusedItem.Text;
            selectedName_input.Text = unknownDevices_list.FocusedItem.SubItems[1].Text;
        }

        #region Buttons
        private void manScan_Click(object sender, EventArgs e)
        {
            if (Program.scanStarted)
            {
                Program.scanStarted = false;
                Program.updating = false;
                Program.stopScanner();
                scanToggle_button.Text = "Enable scanning";
                scanStatus.Text = "Scanning disabled";
            }
            else
            {
                Program.scanStarted = true;
                Program.updating = true;
                Program.startScanner();
                scanToggle_button.Text = "Disable scanning";
                scanStatus.Text = "Scanning enabled";
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            long output;

            if (long.TryParse(selectedMac_input.Text, System.Globalization.NumberStyles.HexNumber, null, out output) && (selectedMac_input.Text.Length == 12))
            {
                if (selectedName_input.Text != "")
                {
                    if (Program.tryPairing(BluetoothAddress.Parse(selectedMac_input.Text), pin_input.Text))
                    {
                        removeFromListView(unknownDevices_list, selectedMac_input.Text);

                        string[] strArr = { selectedMac_input.Text, selectedName_input.Text };
                        ListViewItem temp = new ListViewItem(strArr);
                        knownDevices_list.Items.Add(temp);

                        string[] strArrOnline = { selectedMac_input.Text, selectedName_input.Text, DateTime.Now.ToShortTimeString() };
                        ListViewItem tempOnline = new ListViewItem(strArrOnline);
                        removeFromListView(onlineDevices_list, selectedMac_input.Text);
                        onlineDevices_list.Items.Add(tempOnline);

                        Program.knownDevices.Add(selectedMac_input.Text, new Device(selectedMac_input.Text, selectedName_input.Text, DateTime.Now));
                        Program.savedDevicesHanlder.saveToFile(Program.settings_.Get("savedDevicesPath") + Program.settings_.Get("savedDevicesFile"));

                        Program.keepalive(selectedMac_input.Text, selectedName_input.Text);
                    }
                    else
                    {
                        MessageBox.Show("Authentication not successful!");
                    }
                }
                else
                {
                    MessageBox.Show("Please type in a name for this device");
                }
            }
            else
            {
                MessageBox.Show("Wrong MAC-ID");
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            Form pw = new Password();
            if (pw.ShowDialog(this) == DialogResult.OK)
            {
                Program.knownDevices.Remove(knownDevices_list.FocusedItem.Text);
                removeFromListView(onlineDevices_list, knownDevices_list.FocusedItem.Text);
                knownDevices_list.Items.Remove(knownDevices_list.FocusedItem);
            }
        }

        private void settings_Click(object sender, EventArgs e)
        {
            Form pw = new Password();
            if (pw.ShowDialog(this) == DialogResult.OK)
            {
                new Settings().Show();
            }
        }

        private void info_button_Click(object sender, EventArgs e)
        {
            new About().Show();
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
            {
                this.Hide();
            }
        }

        private void toSystray_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            WindowState = FormWindowState.Normal;
        }

        private void show_item_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void close_item_Click(object sender, EventArgs e)
        {
            closeFromSystray = true;
            this.Close();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.TaskManagerClosing && e.CloseReason != CloseReason.WindowsShutDown && !closeFromSystray)
            {
                e.Cancel = true;
            }
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region Invokers

        public void invokeScanSleeping()
        {
            this.BeginInvoke(new refreshDelegate(scanSleeping));
        }

        public void invokeScanStarted()
        {
            this.BeginInvoke(new refreshDelegate(scanStarted));
        }

        public void invokeUpdatingDevice()
        {
            this.BeginInvoke(new refreshDelegate(updatingDevice));
        }

        public void invokeNewOnlineDevice()
        {
            this.BeginInvoke(new refreshDelegate(newOnlineDevice));
        }

        public void invokeNewUnknownDevice()
        {
            this.BeginInvoke(new refreshDelegate(newUnknownDevice));
        }

        public void invokeListsClear()
        {
            this.BeginInvoke(new refreshDelegate(unknownDevices_list.Items.Clear));
            this.BeginInvoke(new refreshDelegate(onlineDevices_list.Items.Clear));
        }

        public void invokeClearUnknownDevices()
        {
            this.BeginInvoke(new refreshDelegate(unknownDevices_list.Items.Clear));
        }

        public void invokeRemoveOnlineDevice()
        {
            this.BeginInvoke(new refreshDelegate(removeOnlineDevice));
        }
        #endregion

        #region Devicelists Refreshers
        public void newOnlineDevice()
        {
            BluetoothAddress macid = Program.btCurrentDevice.DeviceAddress;
            string[] strArr = { macid.ToString(), Program.knownDevices[macid.ToString()].name, Program.knownDevices[macid.ToString()].lastPairTry.ToShortTimeString() };
            ListViewItem temp = new ListViewItem(strArr);
            onlineDevices_list.Items.Add(temp);
        }

        public void newUnknownDevice()
        {
            BluetoothAddress macid = Program.btCurrentDevice.DeviceAddress;
            string[] strArr = { macid.ToString(), Program.btClient.GetRemoteMachineName(macid) };
            ListViewItem temp = new ListViewItem(strArr);
            unknownDevices_list.Items.Add(temp);
        }

        private void refreshKnownDevices()
        {
            knownDevices_list.Items.Clear();

            foreach (KeyValuePair<string, Device> currentDevice in Program.knownDevices)
            {
                string[] strArr = { currentDevice.Value.macid, currentDevice.Value.name };
                ListViewItem temp = new ListViewItem(strArr);
                knownDevices_list.Items.Add(temp);
            }
        }

        private void removeOnlineDevice()
        {
            removeFromListView(onlineDevices_list, Program.currentDevice.macid);
        }

        private bool removeFromListView(ListView lv, string item)
        {
            bool found = false;
            int i = 0;
            while (!found && i < lv.Items.Count)
            {
                if (lv.Items[i].Text == item)
                {
                    lv.Items.Remove(lv.Items[i]);
                    found = true;
                }
                i++;
            }
            return found;
        }
        #endregion

        #region StatusStrip Refreshers
        private void scanSleeping()
        {
            scanStatus.Text = "Updating sleeps for " + Program.settings_.Get("refreshInterval") + " seconds";
        }

        private void scanStarted()
        {
            scanStatus.Text = "Searching for unknown devices...";
        }

        private void updatingDevice()
        {
            scanStatus.Text = "Checking online status of \"" + Program.currentDevice.name + "\"";
        }
        #endregion
    }
}
