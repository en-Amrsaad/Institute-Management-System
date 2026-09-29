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
    public partial class course : Form
    {
        public course()
        {
            InitializeComponent();
        }
        registrationClass d = new registrationClass();
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("plesa insert value", "system", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                d.dml(@"INSERT INTO [dbo].[Table_cou]
           ([name_cou]
           ,[Hour_cou]
           ,[price_cou])
     VALUES
           (N'" + textBox1.Text + "',N'" + textBox2.Text + "',N'" + textBox3.Text + "')");
                cl();
                MessageBox.Show("the insert is done", "system message", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                data();

            }
        }
        private void data()
        {
            dataGridView1.DataSource = d.getdata("select id_cou as'المعرف',name_cou as'اسم المادة',Hour_cou as'ساعات الدراسة',price_cou as'السعر' from Table_cou");
        
        }
        private void cl()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox1.Focus();
        
        }

        private void course_Load(object sender, EventArgs e)
        {
            data();
        }
       
    }
}
