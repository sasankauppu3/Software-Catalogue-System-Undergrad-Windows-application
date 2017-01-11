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
    public partial class remove : Form
    {
        public remove()
        {
            InitializeComponent();
            dataGridView1.Rows.Clear();
            string select = "SELECT name,uploader,type FROM components";
            SqlConnection c = new SqlConnection();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(select, @"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\Users\MUNTIN\Desktop\software catalogue1\software catalogue\softwaredb.mdf;Integrated Security=True");

            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[rowIndex];
            string compname = row.Cells["name"].Value.ToString();

            string constring = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\Users\MUNTIN\Desktop\software catalogue1\software catalogue\softwaredb.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(constring);
            SqlCommand cmd = new SqlCommand("delete from components where name = @name", con);
            cmd.Parameters.AddWithValue("@name", compname);
            
            con.Open();
            cmd.ExecuteNonQuery();

            con.Close();

            File.Delete(@"D:\Users\MUNTIN\Desktop\software catalogue1\software catalogue\requested\" + compname);
            this.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
