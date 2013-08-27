using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Threading;
using InTheHand.Net;
using InTheHand.Net.Bluetooth;
using InTheHand.Net.Bluetooth.AttributeIds;
using InTheHand.Net.Sockets;
using System.Net;
using System.Text;
using NETExtensions;

namespace BTRecognizer
{
    static class Program
    {
        // General Variables
        public static string appPath = Application.StartupPath;
        public static bool running = true;
        public static bool scanStarted = true;
        public static bool updating = true;

        // BT related variables
        public static BluetoothClient btClient;
        public static BluetoothDeviceInfo[] btDevices;
        public static BluetoothDeviceInfo btCurrentDevice;

        public static Device currentDevice;

        // Scanner related variables
        static Updater scanner;
        static Thread scanThread;

        // HTTP related variables
        static HttpWebResponse response;

        // Storing information
        //public static Dictionary<string, string> knownDevices;
        public static Dictionary<string, Device> knownDevices;
        public static NETExtensions.Properties settings_ = new NETExtensions.Properties();
        public static XMLHandler savedDevicesHanlder = new XMLHandler();

        public static MainForm mainForm;

        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            if (!BluetoothRadio.IsSupported)
            {
                MessageBox.Show("No Bluetooth available");
                Application.Exit();
            }
            else
            {   
                btClient = new BluetoothClient();
                knownDevices = new Dictionary<string, Device>();

                if (System.IO.File.Exists("settings.xml"))
                {
                    settings_.Load("settings.xml");

                    knownDevices = savedDevicesHanlder.parse(settings_.Get("savedDevicesPath") + settings_.Get("savedDevicesFile"));
                    settings_.Get("savedDevicesPath");

                    scanner = new Updater();
                    scanThread = new Thread(new ThreadStart(scanner.startUpdate));

                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(mainForm = new MainForm());
                    running = false;
                    scanStarted = false;
                    updating = false;
                    btClient.Dispose();
                    try
                    {
                        scanThread.Abort();
                    }
                    catch (ThreadStateException e)
                    {
                        System.Diagnostics.Debug.WriteLine(e.ToString());
                        scanThread.Resume();
                        scanThread.Abort();
                    }
                    savedDevicesHanlder.saveToFile(settings_.Get("savedDevicesPath") + settings_.Get("savedDevicesFile"));
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show("settings.xml not found");
                    Application.Exit();
                }
            }
        }

        #region Blknownuetooth handling
        public static void startScanner()
        {
            if (scanThread.ThreadState == ThreadState.Unstarted)
            {
                scanThread.Start();
            }
            else
            {
                scanThread.Resume();
            }
        }

        public static void stopScanner()
        {
            scanThread.Suspend();
        }

        public static void updateDevices()
        {
            try
            {

                foreach (KeyValuePair<string, Device> kvp in knownDevices)
                {
                    currentDevice = kvp.Value;
                    btCurrentDevice = new BluetoothDeviceInfo(BluetoothAddress.Parse(currentDevice.macid));

                    if ((DateTime.Now - currentDevice.lastPairTry).TotalSeconds > (int.Parse(settings_.Get("timeToLive")) * 60))
                    {
                        mainForm.invokeUpdatingDevice();
                        System.Diagnostics.Debug.WriteLine("Not tried to pair with device " + currentDevice.name + " for more than " + (int.Parse(settings_.Get("timeToLive")) * 60) + " seconds. Try to pair known device now.");
                        // Checking if in range with Pair Request

                        if (tryPairing(BluetoothAddress.Parse(currentDevice.macid), "0000"))
                        {
                            // Just in case that the paired device has been removed exactly while pairing
                            if (knownDevices.ContainsKey(currentDevice.macid))
                            {
                                mainForm.invokeRemoveOnlineDevice();
                                knownDevices[currentDevice.macid].lastPairTry = DateTime.Now;
                                mainForm.invokeRemoveOnlineDevice();
                                mainForm.invokeNewOnlineDevice();
                                keepalive(currentDevice.macid, currentDevice.name);
                            }
                            else
                            {
                                mainForm.invokeRemoveOnlineDevice();
                                System.Diagnostics.Debug.WriteLine("Paired device " + currentDevice.name + " not longer in list of known devices!");
                            }
                        }
                        else
                        {
                            mainForm.invokeRemoveOnlineDevice();
                            knownDevices[currentDevice.macid].lastPairTry = DateTime.Now;
                        }
                    }
                    else
                    {
                        System.Diagnostics.Debug.WriteLine("Tried to pair with device " + currentDevice.name + " in the last " + (int.Parse(settings_.Get("timeToLive")) * 60) + " seconds");
                    }
                }
            }
            catch (InvalidOperationException e)
            {
                System.Diagnostics.Debug.WriteLine(e.ToString());
            }

            mainForm.invokeScanStarted();
            btDevices = btClient.DiscoverDevices();
            mainForm.invokeClearUnknownDevices();
            foreach (BluetoothDeviceInfo device in btDevices)
            {
                btCurrentDevice = device;
                if (!knownDevices.ContainsKey(device.DeviceAddress.ToString()))
                {
                    mainForm.invokeNewUnknownDevice();
                }
                Thread.Sleep(50);
            }
            mainForm.invokeScanSleeping();
        }

        public static bool tryPairing(BluetoothAddress btAdr, string pin)
        {
            updating = false;
            if (BluetoothSecurity.PairRequest(btAdr, pin))
            {
                updating = true;
                return true;
            }
            else
            {
                updating = true;
                return false;
            }
        }
        #endregion

        #region Webupdates
        public static void keepalive(string macid, string name)
        {
            //HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://www.lillavaxthuset.org/");
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://www.lillavaxthuset.org/btkeepalive.php?name=" + name + "&macid=" + macid);
            sendRequest(request);
        }

        public static void remove(string macid, string name)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://www.lillavaxthuset.org/");
            //HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://www.lillavaxthuset.org/btremove.php?name=" + name + "&macid=" + macid);
            sendRequest(request);
        }

        static void sendRequest(HttpWebRequest request)
        {
            request.Credentials = CredentialCache.DefaultCredentials;
            request.UserAgent = "BTRecognizer";
            request.KeepAlive = true;
            request.Headers.Set("Pragma", "no-cache");
            request.Timeout = 300000;
            request.Method = "GET";

            if (response != null)
            {
                response.Close();
                response = null;
            }

            try
            {
                response = (HttpWebResponse)request.GetResponse();
                System.Diagnostics.Debug.WriteLine("Status Code from " + request.RequestUri.AbsoluteUri.ToString() + ": " + response.StatusCode);
            }
            catch (WebException e)
            {
                if (settings_.Get("updateFailedMessage") == "true")
                {
                    MessageBox.Show("Failed to update the device on the webserver. Please check your online status!");
                }
                System.Diagnostics.Debug.WriteLine(e.ToString());
            }
        }
        #endregion
    }
}