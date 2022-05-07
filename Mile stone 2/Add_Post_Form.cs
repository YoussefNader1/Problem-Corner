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
    public partial class Add_Post_Form : Form
    {
        String ordb = "Data source=orcl; user id=scott;Password=tiger;";
        int id;
        OracleConnection con;
        public Add_Post_Form(int userId)
        {
            InitializeComponent();
            id = userId;
        }

        private void btn_AddPost_Click(object sender, EventArgs e)
        {
            if (txt_AddPost.Text == "" )
            {
                MessageBox.Show("Field is empty");
                return;
            }
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = con;
            cmd.CommandText = "insert into posts values(:POSTID,:POSTCONTENT,:USERID)";
            
            OracleCommand cmd1 = new OracleCommand();
            cmd1.Connection = con;
            cmd1.CommandText = "select max(POSTID) from posts ";
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
            cmd.Parameters.Add("POSTID", newid);
            cmd.Parameters.Add("POSTCONTENT", txt_AddPost.Text);
            cmd.Parameters.Add("USERID", id);

            int r = cmd.ExecuteNonQuery();
            if (r != -1)
            {
                MessageBox.Show("Post added");

                Home l = new Home(id);
                l.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Please Add Something");
            }
        }

        private void Add_Post_Form_Load(object sender, EventArgs e)
        {
            con = new OracleConnection(ordb);
            con.Open();
        }

        private void txt_AddPost_TextChanged(object sender, EventArgs e)
        {

        }

        private void Add_Post_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            con.Dispose();
        }
    }
}
