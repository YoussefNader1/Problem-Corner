using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;
namespace Mile_stone_2
{
    public partial class CrystalReportForm : Form
    {
        AlldataCrystalReport ACR;
        SearchCrystalReport SCR;
        public CrystalReportForm()
        {
            InitializeComponent();
        }

        private void CrystalReportForm_Load(object sender, EventArgs e)
        {
            ACR = new AlldataCrystalReport();
            SCR = new SearchCrystalReport();
            SCR.SetParameterValue(0, "");
            crystalReportViewer1.ReportSource = ACR;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (ss.Text == "")
            {
                crystalReportViewer1.ReportSource = ACR;
            }
            else
            {
                SCR.SetParameterValue(0, ss.Text);
                crystalReportViewer1.ReportSource = SCR;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ss_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
