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
    public partial class Login : Form
    {
        OracleConnection con;
        String ordb = "Data source=orcl; user id=scott;Password=tiger;";

        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_user.Text == "" || txt_password.Text == "")
            {
                MessageBox.Show("Filed is empty");
                return;
            }
            int returnedID = 0;
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "getPosts";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("username",txt_user.Text);
            cmd.Parameters.Add("password",txt_password.Text);
            cmd.Parameters.Add("id", OracleDbType.Int32, ParameterDirection.Output);
            try
            {
                cmd.ExecuteNonQuery();
                returnedID = Convert.ToInt32(cmd.Parameters["id"].Value.ToString());
                Home h = new Home(returnedID);
                h.Show();
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERROR: Invalid Username or Password!!!");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            con = new OracleConnection(ordb);
            con.Open();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
