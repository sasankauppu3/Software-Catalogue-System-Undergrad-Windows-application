using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace software_catalogue
{
    public partial class request : Form
    {
        public request()
        {
            InitializeComponent();
            dataGridView1.Rows.Clear();
            string select = "SELECT name,uploader FROM components where status = '" + "requested" + "'";
            SqlConnection c = new SqlConnection();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(select, @"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\Users\MUNTIN\Desktop\software catalogue1\software catalogue\softwaredb.mdf;Integrated Security=True");

            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string constring = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=D:\Users\MUNTIN\Desktop\software catalogue1\software catalogue\softwaredb.mdf;Integrated Security=True";
            SqlConnection con = new SqlConnection(constring);
            SqlCommand cmd = new SqlCommand("Update components set status = '" + "approved" + "' where status = '" + "requested" + "'",con);
            
            con.Open();
            cmd.ExecuteNonQuery();

            con.Close();
            this.Close();
        }
    }
    }
