using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project.school
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        registrationClass x = new registrationClass();

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = x.getdata("select * from Table_user where username='" + textBox1.Text + "' and password='" + textBox2.Text + "'");
            if (dt.Rows.Count > 0)
            {
                Form1 n = new Form1();
                n.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("This user is noy found", "system message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
    }
}
