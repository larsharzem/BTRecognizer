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
    public partial class Password : Form
    {
        public Password()
        {
            InitializeComponent();
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void password_button_Click(object sender, EventArgs e)
        {
            if (password_input.Text == Program.settings_.Get("editingPassword"))
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Wrong Password");
            }
        }
    }
}
