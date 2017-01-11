using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace software_catalogue
{
    public partial class adhome : Form
    {
        public adhome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            login.Show();
            this.Hide();
        }

       


        private void button4_Click(object sender, EventArgs e)
        {
            ad_remuser a = new ad_remuser();
            a.Show();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            request form = new request();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            generaterep form = new generaterep();
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            upload form = new upload("admin");
            form.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            remove form = new remove();
            form.Show();
        }

      

       
    }
}
