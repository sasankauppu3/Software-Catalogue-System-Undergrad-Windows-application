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
    public partial class generaterep : Form
    {
        public generaterep()
        {
            InitializeComponent();
            dataGridView2.Rows.Clear();
            string select = "SELECT name,uploader,type FROM components";
            SqlConnection c = new SqlConnection();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(select, @"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\Users\MUNTIN\Desktop\software catalogue1\software catalogue\softwaredb.mdf;Integrated Security=True");

            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0];

            dataGridView3.Rows.Clear();
             select = "SELECT username,designation FROM userinfo";
             c = new SqlConnection();
             dataAdapter = new SqlDataAdapter(select, @"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\Users\MUNTIN\Desktop\software catalogue1\software catalogue\softwaredb.mdf;Integrated Security=True");

             commandBuilder = new SqlCommandBuilder(dataAdapter);
             ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView3.DataSource = ds.Tables[0];
        }

        private void generaterep_Load(object sender, EventArgs e)
        {

        }


        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
