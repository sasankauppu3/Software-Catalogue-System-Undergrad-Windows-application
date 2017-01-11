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
using System.IO;
namespace software_catalogue
{
    public partial class home : Form
    {
        string user;
        public home(string username)
        {
            InitializeComponent();
            welcomemsg.Text += username;
            user = username;
            dataGridView1.Rows.Clear();
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string search=textBox1.Text;
            dataGridView1.Rows.Clear();
            string constring = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\Users\MUNTIN\Desktop\software catalogue1\software catalogue\softwaredb.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(constring);
            SqlCommand cmd1 = new SqlCommand("select * from components where status='" + "approved" +"'", con);
            con.Open();

            SqlDataReader reader1 = cmd1.ExecuteReader();
                
                while (reader1.Read())
                {
                    //if (reader1["status"].ToString() == "approved")
                    //{
                        if ((search == reader1["keyword1"].ToString() || search == reader1["keyword2"].ToString() || search == reader1["name"].ToString()))
                        {
                            DataGridViewRow row = new DataGridViewRow();
                            dataGridView1.Rows.Add(row);
                            //DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();

                            row.Cells["ComponentName"].Value = reader1["name"].ToString();
                            row.Cells["Uploader"].Value = reader1["uploader"].ToString();
                            row.Cells["DateModified"].Value = reader1["datemodified"].ToString();
                            row.Cells["Type"].Value = reader1["type"].ToString();
                            //dataGridView1.Rows.Add(row);
                        }
                    //}
                }
                con.Close();
        }

        private void Upload_Click(object sender, EventArgs e)
        {
            upload form = new upload(user);
            form.Show();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[rowIndex];
            File.Copy(@"D:\Users\MUNTIN\Desktop\software catalogue1\software catalogue\requested\" + row.Cells["ComponentName"].Value, @"D:\Users\Public\Documents\" + row.Cells["ComponentName"].Value, true);
        }
    }
}
