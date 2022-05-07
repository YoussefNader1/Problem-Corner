using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mile_stone_2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void adminFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin a=new Admin();
            a.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CrystalReportForm cf = new CrystalReportForm();
            cf.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login l =new Login();
            l.Show();
            Hide();

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}
