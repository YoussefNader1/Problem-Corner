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
    public partial class Admin : Form
    {
        OracleDataAdapter adabter;
        OracleCommandBuilder builder;
        DataSet ds;
        String constr = "Data source=orcl; user id=scott;Password=tiger;";
        string cmdstr = "";
        object s;
        EventArgs e;
        public Admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Filed is empty");
                return;
            }
            cmdstr = "select  postcontent,postid from posts where userid=:id";
            adabter = new OracleDataAdapter(cmdstr, constr);
            adabter.SelectCommand.Parameters.Add("id", textBox1.Text);
            ds = new DataSet();
            adabter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txt_postID.Text == "")
            {
                MessageBox.Show("Filed is empty");
                return;
            }
            //post using Subqueries
            cmdstr = "delete from coomment co where co.postid IN (SELECT posts.postid FROM   posts WHERE posts.postid = :id)";
            adabter = new OracleDataAdapter(cmdstr, constr);
            adabter.SelectCommand.Parameters.Add("id", txt_postID.Text);
            ds = new DataSet();
            adabter.Fill(ds);

            //post
            cmdstr = "delete from posts where postid=:id";
            adabter = new OracleDataAdapter(cmdstr, constr);
            adabter.SelectCommand.Parameters.Add("id", txt_postID.Text);
            ds = new DataSet();
            adabter.Fill(ds);
            button1_Click(s, e);
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            cmdstr = "select postcontent,postid from posts";
            adabter = new OracleDataAdapter(cmdstr, constr);
            ds = new DataSet();
            adabter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
