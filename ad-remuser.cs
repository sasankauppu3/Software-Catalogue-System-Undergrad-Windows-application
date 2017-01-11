using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
namespace software_catalogue
{
    public partial class ad_remuser : Form
    {
        public ad_remuser()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string constring = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\Users\MUNTIN\Desktop\software catalogue1\software catalogue\SOFTWAREDB.MDF;Integrated Security=True";
            SqlConnection con = new SqlConnection(constring);
            SqlCommand cmd1 = new SqlCommand("select username from userinfo ", con);
            con.Open();

            SqlDataReader reader1 = cmd1.ExecuteReader();
            int flag = 0;
            while (reader1.Read())
            {

                if (username == reader1["username"].ToString())
                {
                    flag = 1;
                }
            }
            if (flag != 1)
            {
                errmsg1.Text = "User doesn't exist try another user";

            }
            else
            {
                SqlConnection con1 = new SqlConnection(constring);
                SqlCommand cmd = new SqlCommand("delete from userinfo where username = '" + username + "'", con1);

                con1.Open();

                cmd.ExecuteNonQuery();
                con1.Close();
                errmsg1.Text = "User Deleted Successfully!!";
                textBox1.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

    }
}
