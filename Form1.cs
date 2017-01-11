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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username1 = username.Text;
            string constring = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\Users\MUNTIN\Desktop\software catalogue1\software catalogue\softwaredb.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(constring);
            SqlCommand cmd1 = new SqlCommand("select name,password from userinfo where username ='" + username1 + "'",con);
            con.Open();
           
            SqlDataReader reader1 = cmd1.ExecuteReader();
            reader1.Read();
            if (!reader1.HasRows)
            {
                error.Text = "User not found";
            }
            else if (password.Text != reader1["password"].ToString())
            {
                error.Text = "Incorrect password";
            }
            else if(username1=="admin"&&password.Text=="admin")
            {
                adhome homepage = new adhome();
                homepage.Show();
                this.Hide();
            }
            else
            {
                home homepage = new home(reader1["name"].ToString());
                homepage.Show();
                this.Hide();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            register f = new register();
            f.Show();
            this.Hide();
        }
    }
}
