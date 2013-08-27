using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace BTRecognizer
{
    public class Updater
    {
        public Updater()
        {
        }

        public void startUpdate()
        {
            while (Program.running)
            {
                if (Program.updating)
                {
                    Program.updateDevices();
                    Thread.Sleep(int.Parse(Program.settings_.Get("refreshInterval")) * 1000);
                }
            }
        }
    }
}
