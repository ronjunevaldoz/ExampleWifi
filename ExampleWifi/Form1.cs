using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExampleWifi
{
    public partial class Form1 : Form
    {
        Hotspot h = null;
        public Form1()
        {
            h = new Hotspot();
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            h.Stop();
            populateConnections();

        }

        public void populateConnections()
        {
            cmbConnection.Items.Clear();
            h.GetConnections().ForEach(conProp => { cmbConnection.Items.Add(conProp); });
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            h.create(txtSSID.Text , txtKEY.Text);
            h.start();
            populateConnections();
            lblMessage.Text = h.Message;
        }

        private void btnShare_Click(object sender, EventArgs e)
        {
            h.ShareInternet("Ethernet", cmbConnection.SelectedItem.ToString(), true);
            lblMessage.Text = h.Message;
        }

        private void btnDisableInternet_Click(object sender, EventArgs e)
        {
            h.ShareInternet("Ethernet", cmbConnection.SelectedItem.ToString(), false);
            lblMessage.Text = h.Message;
        }
    }
}
