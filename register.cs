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
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }
        private int enteries=1;
        private void button1_Click(object sender, EventArgs e)
        {
            label6.Text = "";
            ermsg.Text = "";

            if (textBox2.Text == textBox3.Text)
            {
                string username = textBox1.Text;
                string password = textBox2.Text;
                string name = textBox4.Text;
                string designation = textBox5.Text;
                string constring = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\Users\MUNTIN\Desktop\software catalogue1\software catalogue\softwaredb.mdf;Integrated Security=True";
                SqlConnection con = new SqlConnection(constring);
                SqlCommand cmd1 = new SqlCommand("select username from userinfo ", con);
                con.Open();

                SqlDataReader reader1 = cmd1.ExecuteReader();
                int flag = 0;
                while (reader1.Read())
                {
                    enteries++;
                    if (username == reader1["username"].ToString())
                    {
                        flag = 1;
                    }
                }
                con.Close();
                if (flag == 1)
                {
                    textBox1.Text = "";
                    ermsg.Text = "*Username already exists";

                }
                else
                {
                    SqlConnection con1 = new SqlConnection(constring);
                    SqlCommand cmd = new SqlCommand("insert into userinfo(username,password,name,designation) values('" + username + "','" + password + "','" + name + "','" + designation + "')", con1);

                    con1.Open();

                    cmd.ExecuteNonQuery();
                    con1.Close();
                    Form1 h = new Form1();
                    h.Show();
                    this.Hide();
                }


            }
            else
            {
                label6.Text = "*Please enter the same password";
            }

        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            
            Form1 h = new Form1();
            h.Show();
            this.Hide();
        }

        private void register_Load(object sender, EventArgs e)
        {

        }
    }
}
