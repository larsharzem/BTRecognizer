using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BTRecognizer
{
    class Device
    {
        public string macid;
        public string name;
        public DateTime lastPairTry;

        public Device(string macid, string name, DateTime lastPairTry)
        {
            this.macid = macid;
            this.name = name;
            this.lastPairTry = lastPairTry;
        }
    }
}
