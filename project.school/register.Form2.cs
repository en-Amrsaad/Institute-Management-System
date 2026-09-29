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
    public partial class register : Form
    {
        public register()
        {
            InitializeComponent();
        }


        registrationClass r = new registrationClass();

        private void button1_Click(object sender, EventArgs e)
        {
           
            string g = "ذكر";
            if (radioButton1.Checked)
            {
                g = "ذكر";

            }
            else
            {
                g = "انثى";
            }
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("plesa insert value", "system", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                r.dml(@"INSERT INTO [dbo].[regist_table]
           ([f_name]
           ,[l_name]
           ,[phone]
           ,[birthdate]
           ,[gender]
           ,[address])
     VALUES
           (N'" + textBox1.Text + "',N'" + textBox2.Text + @"',N'" + maskedTextBox1.Text + @"',N'" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + @"',N'" + g + @"',N'" + textBox3.Text + @"')");
                MessageBox.Show("the seve is done", "system", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Clear();
                textBox2.Clear();
                maskedTextBox1.Clear();
                textBox3.Clear();
                textBox1.Focus();
                data();
            }
        }
        private void data()
        {
            dataGridView1.DataSource = r.getdata("select id as'المعرف',f_name as'الاسم الاول',l_name as'الاسم الثاني',phone as'رقم الهاتف',birthdate as'تاريخ الميلاد' ,gender as'الجنس',address as'العنوان' from regist_table ");

        }

        private void register_Load(object sender, EventArgs e)
        {
            data();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}
