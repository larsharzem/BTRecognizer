using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BTRecognizer
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            if (Program.settings_.Get("savedDevicesPath") == "" || Program.settings_.Get("savedDevicesFile") == Program.appPath)
            {
                saveFilePosition_input.Text += "";
            }
            else
            {
                saveFilePosition_input.Text += Program.settings_.Get("savedDevicesPath");
            }
            saveFilePosition_input.Text += Program.settings_.Get("savedDevicesFile");

            switch (int.Parse(Program.settings_.Get("refreshInterval")))
            {
                case 5:
                    refreshInterval_input.SelectedItem = refreshInterval_input.Items[0];
                    break;

                case 10:
                    refreshInterval_input.SelectedItem = refreshInterval_input.Items[1];
                    break;

                case 15:
                    refreshInterval_input.SelectedItem = refreshInterval_input.Items[2];
                    break;

                case 20:
                    refreshInterval_input.SelectedItem = refreshInterval_input.Items[3];
                    break;

                case 30:
                    refreshInterval_input.SelectedItem = refreshInterval_input.Items[4];
                    break;

                case 60:
                    refreshInterval_input.SelectedItem = refreshInterval_input.Items[5];
                    break;

                case 120:
                    refreshInterval_input.SelectedItem = refreshInterval_input.Items[6];
                    break;

                default:
                    refreshInterval_input.SelectedItem = refreshInterval_input.Items[1];
                    break;
            }

            switch (int.Parse(Program.settings_.Get("timeToLive")))
            {
                case 1:
                    timeToLive_input.SelectedItem = timeToLive_input.Items[0];
                    break;

                case 2:
                    timeToLive_input.SelectedItem = timeToLive_input.Items[1];
                    break;

                case 3:
                    timeToLive_input.SelectedItem = timeToLive_input.Items[2];
                    break;

                case 5:
                    timeToLive_input.SelectedItem = timeToLive_input.Items[3];
                    break;

                case 7:
                    timeToLive_input.SelectedItem = timeToLive_input.Items[4];
                    break;

                case 10:
                    timeToLive_input.SelectedItem = timeToLive_input.Items[5];
                    break;

                case 15:
                    timeToLive_input.SelectedItem = timeToLive_input.Items[6];
                    break;

                default:
                    timeToLive_input.SelectedItem = timeToLive_input.Items[3];
                    break;
            }

            if (Program.settings_.Get("updateFailedMessage") == "true")
            {
                updateFailedMessage_checkbox.Checked = true;
            }

            editingPassword_input.Text = Program.settings_.Get("editingPassword");

            savedFileBrowse.FileOk += new CancelEventHandler(fileChosen);
            refreshInterval_input.SelectedIndexChanged += new EventHandler(refreshIntervalChosen);
            timeToLive_input.SelectedIndexChanged += new EventHandler(refreshTimeToLiveChosen);
        }

        private void savedFileButton_Click(object sender, EventArgs e)
        {
            savedFileBrowse.ShowDialog();
        }

        private void fileChosen(object sender, EventArgs e)
        {
            if (savedFileBrowse.FileName.Substring(0, (savedFileBrowse.FileName.Length - (savedFileBrowse.SafeFileName.Length+1))) == Program.appPath)
            {
                saveFilePosition_input.Text = savedFileBrowse.SafeFileName;
                Program.settings_.Set("savedDevicesFile", savedFileBrowse.SafeFileName);
                Program.settings_.Set("savedDevicesPath", "");
            }
            else
            {
                saveFilePosition_input.Text = savedFileBrowse.FileName;
                Program.settings_.Set("savedDevicesFile", savedFileBrowse.SafeFileName);
                Program.settings_.Set("savedDevicesPath", savedFileBrowse.FileName.Substring(0, (savedFileBrowse.FileName.Length - (savedFileBrowse.SafeFileName.Length))));
            }
        }

        private void refreshTimeToLiveChosen(object sender, EventArgs e)
        {
            string temp = timeToLive_input.SelectedItem.ToString();
            temp = temp.Substring(0, (temp.Length - 10));
            Program.settings_.Set("timeToLive", temp);
        }

        private void refreshIntervalChosen(object sender, EventArgs e)
        {
            string temp = refreshInterval_input.SelectedItem.ToString();
            temp = temp.Substring(0, (temp.Length - 8));
            Program.settings_.Set("refreshInterval", temp);
        }

        private void save_Click(object sender, EventArgs e)
        {
            Program.settings_.Set("editingPassword", editingPassword_input.Text);
            Program.settings_.Save();
            this.Close();
        }

        private void updateFailedMessage_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (updateFailedMessage_checkbox.Checked)
            {
                Program.settings_.Set("updateFailedMessage", "true");
            }
            else
            {
                Program.settings_.Set("updateFailedMessage", "false");
            }
        }
    }
}
