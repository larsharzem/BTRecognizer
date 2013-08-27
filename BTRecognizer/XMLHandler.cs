using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;

namespace BTRecognizer
{
    class XMLHandler
    {
        private XmlTextReader rdr;

        private FileInfo fi;
        private StreamWriter sw;

        public Dictionary<string, Device> knownDevices;
        public XMLHandler()
        {
        }

        public Dictionary<string, Device> parse(string xmlfile)
        {
            rdr = new XmlTextReader(xmlfile);

            string currentMac = null;
            string currentName = null;
            knownDevices = new Dictionary<string, Device>();

            System.Diagnostics.Debug.WriteLine("Reading file: " + xmlfile);

            while (!rdr.EOF)
            {
                try
                {
                    rdr.Read();
                    if (rdr.Depth > 0)
                    {
                        switch (rdr.NodeType)
                        {
                            case XmlNodeType.Element:
                                if (!rdr.IsEmptyElement) // ends with "/>"
                                {
                                    currentMac = rdr.LocalName.Substring(3);
                                    currentName = "";
                                }
                                break;

                            case XmlNodeType.EndElement:
                                try
                                {
                                    knownDevices.Add(currentMac, new Device(currentMac, currentName, DateTime.MinValue));
                                }
                                catch (ArgumentException e)
                                {
                                    System.Diagnostics.Debug.WriteLine(e.ToString());
                                    System.Windows.Forms.MessageBox.Show("This MAC-ID is already present in the list of current devices");
                                }
                                break;

                            case XmlNodeType.Text:
                                currentName = rdr.Value;
                                break;

                            case XmlNodeType.CDATA:
                                currentName = rdr.Value;
                                break;

                            default:
                                // ignore
                                break;
                        }
                    }
                }
                catch (XmlException e)
                {
                    System.Windows.Forms.MessageBox.Show(e.ToString());
                }
            }
            rdr.Close();
            return knownDevices;
        }

        public void saveToFile(string xmlfile)
        {
            fi = new FileInfo(xmlfile);
            sw = fi.CreateText();

            sw.WriteLine("<savedDevices>");
            foreach (KeyValuePair<string, Device> currentDevice in Program.knownDevices)
            {
                sw.WriteLine(new string('\t', 1) + "<" + "mac" + currentDevice.Value.macid + ">" + currentDevice.Value.name + "</" + "mac" + currentDevice.Value.macid + ">");
            }
            sw.WriteLine("</savedDevices>");
            sw.Close();
        }
    }
}
