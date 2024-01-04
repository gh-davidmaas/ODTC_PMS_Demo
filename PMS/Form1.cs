using System;
using System.Net;
using System.Windows.Forms;
using PMS.ODTC;
using PMS.Events;
using PMS.Controls;


namespace PMS {
    public partial class Form1 : Form {


        // The ODTC web service (static bind as Web Reference)
        // another aproach would be to dynamically invoke web services
        // demo projekts can be found here:
        // http://www.crowsprogramming.com/archives/66
        // http://www.codeproject.com/Articles/155481/Web-Service-Communicator
        private InhecoSiLAServiceProvider invoker;


        private Random requestId = new Random((int)DateTime.UtcNow.Ticks);

        private static Form1 form;


        public Form1() {
            InitializeComponent();

            // start the EventReceiver Web Service needed for SiLA Asynchronous Responses
            // ResponseEvent, StatusEvent, DataEvent, ErrorEvent (not invoked by ODTC)
            // requires administrative rights: forced by app.manifest
            new EventReceiver();

            form = this; // static reference for simple logging

            // because the odtc service is built in by compile time, we know it's availbale commands
            // add all commands here
            listBoxSiLACommands.Items.AddRange(new string[] { "Reset", "Initialize", "GetStatus", "OpenDoor", "CloseDoor" });
            listBoxSiLACommands.SelectedIndexChanged += new EventHandler(listBoxSiLACommands_SelectedIndexChanged);
        }


        private void btConnect_Click(object sender, EventArgs e) {
            try {
                Uri uri = new Uri("http://" + tbODTC_IP.Text + ":8080");

                invoker = new InhecoSiLAServiceProvider();

                // now we can change properties
                invoker.Url = uri.ToString();
                invoker.SoapVersion = System.Web.Services.Protocols.SoapProtocolVersion.Soap11;
                invoker.Timeout = 30000;
                //service.Proxy = ...

                listBoxSiLACommands.Enabled = true;
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }


        private void buttonInvoke_Click(object sender, EventArgs e) {
            try {
                switch (listBoxSiLACommands.SelectedItem.ToString()) {
                    case "Reset":
                        ResetControl resetP = panelParameters.Controls[0] as ResetControl;
                        ExecuteReset(resetP.tBLockId.Text, resetP.tBDeviceId.Text, resetP.tBPMSId.Text);
                        break;

                    case "Initialize":
                        InitializeControl initP = panelParameters.Controls[0] as InitializeControl;
                        ExecuteInitialize(initP.tBLockId.Text);
                        break;

                    case "GetStatus":
                        ExecuteGetStatus();
                        break;

                    case "OpenDoor":
                        OpenDoorControl odP = panelParameters.Controls[0] as OpenDoorControl;
                        ExecuteOpenDoor(odP.tBLockId.Text);
                        break;

                    case "CloseDoor":
                        CloseDoorControl cdP = panelParameters.Controls[0] as CloseDoorControl;
                        ExecuteCloseDoor(cdP.tBLockId.Text);
                        break;

                    default:
                        break;
                }
            } catch (WebException ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void listBoxSiLACommands_SelectedIndexChanged(object sender, EventArgs e) {
            btInvoke.Enabled = true;
            if (panelParameters.Controls.Count > 0) {
                panelParameters.Controls.RemoveAt(0);
            }

            switch (((System.Windows.Forms.ListBox)sender).SelectedItem.ToString()) {
                case "Reset":
                    ResetControl resetPanel = new ResetControl();
                    resetPanel.Dock = DockStyle.Fill;
                    panelParameters.Controls.Add(resetPanel);
                    break;

                case "Initialize":
                    InitializeControl initializeControl = new InitializeControl();
                    initializeControl.Dock = DockStyle.Fill;
                    panelParameters.Controls.Add(initializeControl);
                    break;

                case "GetStatus":
                    break;

                case "OpenDoor":
                    OpenDoorControl odControl = new OpenDoorControl();
                    odControl.Dock = DockStyle.Fill;
                    panelParameters.Controls.Add(odControl);
                    break;

                case "CloseDoor":
                    CloseDoorControl cdControl = new CloseDoorControl();
                    cdControl.Dock = DockStyle.Fill;
                    panelParameters.Controls.Add(cdControl);
                    break;

                default:
                    btInvoke.Enabled = false;
                    break;
            }
        }


        internal static void Log(string message) {
            form.tBLog.Text += message;
            form.tBLog.Text += "\r\n";
            // scroll to end
            form.tBLog.SelectionStart = form.tBLog.Text.Length;
            form.tBLog.ScrollToCaret();
        }


        private void ExecuteReset(string lockId, string deviceId, string pmsId) {
            Log("Invoke SiLA Reset");
            ODTC.SiLAReturnValue rv = invoker.Reset(requestId.Next(), lockId, deviceId, EventReceiver.EventReceiverURI, pmsId, "PT10S", false);
            if (rv.returnCode != 2) {
                MessageBox.Show("Unexpected ReturnCode: " + rv.returnCode + "\n" + "Message: " + rv.message);
            }
        }


        private void ExecuteInitialize(string lockId) {
            Log("Invoke SiLA Initialize");
            ODTC.SiLAReturnValue rv = invoker.Initialize(requestId.Next(), lockId);
            if (rv.returnCode != 2) {
                MessageBox.Show("Unexpected ReturnCode: " + rv.returnCode + "\n" + "Message: " + rv.message);
            }
        }


        private void ExecuteGetStatus() {
            Log("Invoke SiLA GetStatus");
            string deviceId;
            State state;
            CommandDescription[] commandDescription;
            bool locked;
            string pmsId;
            DateTime currentTime;
            ODTC.SiLAReturnValue rv = invoker.GetStatus(requestId.Next(), out deviceId, out state, out commandDescription, out locked, out pmsId, out currentTime);
            Log("GetStatus response:");
            Log("DeviceId: " + deviceId);
            Log("Device state: " + state.ToString());
            Log("Locked: " + locked);
            Log("PMSId: " + pmsId);
            Log("Current time: " + currentTime.ToString());
        }


        private void ExecuteOpenDoor(string lockId) {
            Log("Invoke SiLA OpenDoor");
            ODTC.SiLAReturnValue rv = invoker.OpenDoor(requestId.Next(), lockId);
            if (rv.returnCode != 2) {
                MessageBox.Show("Unexpected ReturnCode: " + rv.returnCode + "\n" + "Message: " + rv.message);
            }
        }


        private void ExecuteCloseDoor(string lockId) {
            Log("Invoke SiLA CloseDoor");
            ODTC.SiLAReturnValue rv = invoker.CloseDoor(requestId.Next(), lockId);
            if (rv.returnCode != 2) {
                MessageBox.Show("Unexpected ReturnCode: " + rv.returnCode + "\n" + "Message: " + rv.message);
            }
        }

        private void panelParameters_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
