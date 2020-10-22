using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoCol
{
    public partial class ComSelector : Form
    {
        public ComSelector()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            string comPort = (string)comboBox.SelectedItem;
            if (comPort != null)
            {
                Program.serialCOMDevice.InitializePortConnection(comPort);
                this.Close();
            }
            else
            {

            }
        }
    }
}
