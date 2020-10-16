using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Collator
{
    public partial class ResultViewer : Form
    {
        public ResultViewer()
        {
            InitializeComponent();
        }

        private void ResultViewer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rC12DataSet1.ParliamentarySum' table. You can move, or remove it, as needed.
            //this.parliamentarySumTableAdapter.Fill(this.rC12DataSet1.ParliamentarySum);
            // TODO: This line of code loads data into the 'rC12DataSet1.Results' table. You can move, or remove it, as needed.
            //this.resultsTableAdapter1.Fill(this.rC12DataSet1.Results);
            // TODO: This line of code loads data into the 'rC12DataSet.RS' table. You can move, or remove it, as needed.
            //this.rSTableAdapter.Fill(this.rC12DataSet.RS);
            // TODO: This line of code loads data into the 'rC12DataSet.Results' table. You can move, or remove it, as needed.
            //this.resultsTableAdapter.Fill(this.rC12DataSet.Results);
            //Console.WriteLine(this.Size);
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SerialSelector serialSelector = new SerialSelector();
            serialSelector.Show();
        }

        private void connectbtn_Click(object sender, EventArgs e)
        {
            SerialSelector ss = new SerialSelector();
            ss.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SerialSelector ss = new SerialSelector();
            ss.Show();
        }
    }
}
