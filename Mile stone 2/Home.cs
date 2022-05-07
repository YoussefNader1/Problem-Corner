using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace Mile_stone_2
{
    public partial class Home : Form
    {
        int id;
        String ordb = "Data source=orcl; user id=scott;Password=tiger;";

        OracleConnection conn;
        DataTable dt;
        public Home(int x)
        {
            InitializeComponent();
            id = x;
        }
        public Home()
        {
        }

        private void Home_Load(object sender, EventArgs e)
        {
            dt = new DataTable();
            conn = new OracleConnection(ordb);
            conn.Open();
            dt = new DataTable();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "viewposts";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("id", id);
            cmd.Parameters.Add("cursor", OracleDbType.RefCursor, ParameterDirection.Output);
            OracleDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            dr.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add_Post_Form Addbtn = new  Add_Post_Form(id);
            Addbtn.Show();
            Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            Hide();
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            conn.Dispose();
        }
    }
}