using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.Sql;
using System.Data.SqlClient;

namespace software_catalogue
{
    
    public partial class upload : Form
    {
        string user;
        public upload(string n)
        {
            InitializeComponent();
            user = n;
        }

        private void upload_file_Click(object sender, EventArgs e)
        {
            OpenFileDialog op1 = new OpenFileDialog();
            op1.ShowDialog();
            string s = op1.FileName;
            string[] FName;
            FName = s.Split('\\');
            File.Copy(s, @"D:\Users\MUNTIN\Desktop\software catalogue1\software catalogue\requested\" + FName[FName.Length - 1], true);

            string constring = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\Users\MUNTIN\Desktop\software catalogue1\software catalogue\softwaredb.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(constring);
            SqlCommand cmd = new SqlCommand("INSERT INTO components(name,uploader,datemodified,type,keyword1,keyword2,filepath,status) VALUES(@name,@uploader,@datemodified,@type,@keyword1,@keyword2,@filepath,@status)",con);
            cmd.Parameters.AddWithValue("@name", FName[FName.Length - 1]);
            cmd.Parameters.AddWithValue("@uploader",user);
            cmd.Parameters.AddWithValue("@datemodified", DateTime.Today);
            cmd.Parameters.AddWithValue("@type", textBox3.Text);
            cmd.Parameters.AddWithValue("@keyword1",textBox1.Text );
            cmd.Parameters.AddWithValue("@keyword2", textBox2.Text);
            cmd.Parameters.AddWithValue("@filepath", @"D:\Users\MUNTIN\Desktop\software catalogue1\software catalogue\requested\" + FName[FName.Length - 1]);
            if(user == "admin")
                cmd.Parameters.AddWithValue("@status", "approved");
            else
                cmd.Parameters.AddWithValue("@status", "requested");
            con.Open();
            cmd.ExecuteNonQuery();

            con.Close();
            this.Close();
        }

        private void Type_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
