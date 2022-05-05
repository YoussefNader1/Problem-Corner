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
    public partial class Form1 : Form
    {
        String ordb = "Data source=orcl; user id=scott;Password=tiger;";

        OracleConnection con;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            con = new OracleConnection(ordb);
            con.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_name.Text =="" || txt_password.Text == "") 
            {
                MessageBox.Show("Fild is empty");
                return;
            }
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into usertable values(:id,:name,:pass)";
            OracleCommand cmd1 = new OracleCommand();
            cmd1.Connection = con;
            cmd1.CommandText = "select max(userid) from usertable ";
            OracleDataReader dr = cmd1.ExecuteReader();
            int max = 0;
            try
            {
                dr.Read();
                max = Convert.ToInt32(dr[0]);
            }
            catch
            {
                max = 0;
            }
           int newid = max + 1;
            cmd.Parameters.Add("id", newid);
            cmd.Parameters.Add("name", txt_name.Text);
            cmd.Parameters.Add("gender", txt_password.Text);

            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {
                MessageBox.Show("user add");

                Login l = new Login();
                l.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Please choose new username");
            }
        }
    }
}
