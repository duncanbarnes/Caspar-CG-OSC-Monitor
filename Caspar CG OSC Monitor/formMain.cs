using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Below namepaces are required for OSC operation
using System.Net; 
using Bespoke.Common;
using Bespoke.Common.Osc;

namespace Caspar_CG_OSC_Monitor
{
    public partial class formMain : Form
    {
        /// <summary>
        /// OSC Server instance
        /// </summary>
        private OscServer _OscServer = new OscServer(TransportType.Udp, IPAddress.Any, 6250);


        public formMain()
        {
            InitializeComponent();
            //Subscribe to events that the OSC server raises, Message and BundleReceived
            //some messages from Caspar are sent as bundles/groups of messages, others as
            //individual messages so we need to listen to both to get all data about what
            //Caspar is doing
            this._OscServer.MessageReceived += _OscServer_MessageReceived;
            this._OscServer.BundleReceived += _OscServer_BundleReceived;

        }
        /// <summary>
        /// Handle incoming bundles/groups of messages from the OSC server
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void _OscServer_BundleReceived(object sender, OscBundleReceivedEventArgs e)
        {
            foreach (OscMessage m in e.Bundle.Messages)
            {
                FilterOscMessage(m);
            }
        }
        /// <summary>
        /// Handle incoming individual messages from the OSC Server
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void _OscServer_MessageReceived(object sender, OscMessageReceivedEventArgs e)
        {
            FilterOscMessage(e.Message);
        }
        /// <summary>
        /// Allows basic filtering of some OSC messages before printing the messages to screen
        /// </summary>
        /// <param name="m"></param>
        private void FilterOscMessage(OscMessage m)
        {
            string d1 = m.Data[0].ToString();
            string d2 = (m.Data.Count > 1) ? m.Data[1].ToString() : null;
            string d3 = (m.Data.Count > 2) ? m.Data[2].ToString() : null;

            string[] address = m.Address.ToString().Split('/');
            if (!checkBoxFilterMixer.Checked && address[3] == "mixer") return;
            if (!checkBoxFilterStage.Checked && address[3] == "stage") return;
            if (!checkBoxFilterOutputConsume.Checked && address[3] == "output" && address[4] == "consume_time") return;


            dataGridViewIncomingMessages.Invoke(new MethodInvoker(() => {
                dataGridViewIncomingMessages.Rows.Insert(0, DateTime.Now.ToString("HH:mm:ss"), m.Address.ToString(),d1, d2, d3);
            }));
        }
        /// <summary>
        /// Button click event allowing us to start and stop the OSC Server
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStartStopServer_Click(object sender, EventArgs e)
        {
            if (this._OscServer.IsRunning) //Stop the server
            {
                this.numericUpDownOSCPort.Enabled = true;
                this.buttonStartStopServer.Text = "Start Server";
                this._OscServer.Stop();
            }
            else // Start the server
            {
                this.numericUpDownOSCPort.Enabled = false;
                this.buttonStartStopServer.Text = "Stop Server";
                this._OscServer.Start();
            }
        }
    }
}
