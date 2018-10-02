using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UdpMonitor
{
    public partial class Form1 : Form
    {
        UdpClient _udpClient;

        public Form1()
        {
            InitializeComponent();
            Load += Form1_Load;
            _listViewMessages.Columns.Add("Time", 80, HorizontalAlignment.Left);
            _listViewMessages.Columns.Add("IP", 120, HorizontalAlignment.Left);
            _listViewMessages.Columns.Add("Message", 800, HorizontalAlignment.Left);
        }

        private void _buttonClear_Click(object sender, EventArgs e)
        {
            _listViewMessages.Items.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _udpClient = new UdpClient(12345);
            StartListening();
        }

        IAsyncResult _asyncResult = null;

        private void StartListening()
        {
            _asyncResult = _udpClient.BeginReceive(Receive, null);
        }

        private void Receive(IAsyncResult ar)
        {
            if (_listViewMessages.InvokeRequired)
            {
                BeginInvoke((Action)(() =>
                {
                    Receive(ar);
                }));
            }
            else
            {
                IPEndPoint ip = new IPEndPoint(IPAddress.Any, 12344);
                byte[] bytes = _udpClient.EndReceive(ar, ref ip);
                string message = Encoding.ASCII.GetString(bytes);
                ListViewItem listViewItem = new ListViewItem(new [] 
                {
                    DateTime.Now.ToLongTimeString(),
                    ip.Address.ToString(),
                    message });
                _listViewMessages.Items.Add(listViewItem);
                _listViewMessages.EnsureVisible(_listViewMessages.Items.Count - 1);

                //Console.WriteLine("From {0} received: {1} ", ip.Address.ToString(), message);
                StartListening();
            }
        }
    }
}
