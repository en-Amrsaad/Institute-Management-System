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
    public partial class mange : Form
    {

        public mange()
        {
            InitializeComponent();
        }
        registrationClass v = new registrationClass();
    
        private void data()
        {
            dataGridView1.DataSource = v.getdata("select id as'المعرف',f_name as'الاسم الاول',l_name as'الاسم الثاني',phone as'رقم الهاتف',birthdate as'تاريخ الميلاد' ,gender as'الجنس',address as'العنوان' from regist_table ");

        }

        private void mange_Load(object sender, EventArgs e)
        {
            data();
        }

        private void btnupd_Click(object sender, EventArgs e)
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
            if (MessageBox.Show("Are you sure about the Update", "system message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                v.dml(@"Update regist_table set  f_name =N'" + textBox1.Text + "',l_name =N'" + textBox2.Text + "',phone =N'" + maskedTextBox1.Text + "',birthdate =N'" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "',gender =N'" + g + "',address =N'" + textBox3.Text + "'where id ='" + textBox5.Text + "'");
                MessageBox.Show("the update is done", "system message", MessageBoxButtons.OK, MessageBoxIcon.None);
                data();
            }
        }


        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
          
   
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == 0)
            {
                
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row =this.dataGridView1.Rows[e.RowIndex];
                textBox5.Text = row.Cells["المعرف"].Value.ToString();
                textBox1.Text = row.Cells["الاسم الاول"].Value.ToString();
                textBox2.Text = row.Cells["الاسم الثاني"].Value.ToString();
                maskedTextBox1.Text = row.Cells["رقم الهاتف"].Value.ToString();
                DateTime birthDate; // تعريف المتغير خارج TryParse

                if (DateTime.TryParse(row.Cells["تاريخ الميلاد"].Value.ToString(), out birthDate))
                {
                    dateTimePicker1.Value = birthDate;
                }
                else
                {
                    MessageBox.Show("تنسيق التاريخ غير صالح.");
                    dateTimePicker1.Value = DateTime.Now; // تعيين تاريخ افتراضي
                }

                string gender = row.Cells["الجنس"].Value.ToString();
                if (gender == "ذكر")
                {
                    radioButton1.Checked = true; // ذكر
                }
                else if (gender == "انثى")
                {
                    radioButton2.Checked = true; // أنثى
                }

                textBox3.Text = row.Cells["العنوان"].Value.ToString();

            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = v.getdata("select id as'المعرف',f_name as'الاسم الاول',l_name as'الاسم الثاني',phone as'رقم الهاتف',birthdate as'تاريخ الميلاد' ,gender as'الجنس',address as'العنوان' from regist_table where f_name like N'%" + textBox4.Text + "%'order by id");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure about the deletion", "system message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
            v.dml("delete from regist_table where id ="+textBox5.Text+" ");
            MessageBox.Show("The delete is done", "system message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            maskedTextBox1.Clear();
            dateTimePicker1.Value = DateTime.Now;
            radioButton1.Checked = false; 
            radioButton2.Checked = false;
            textBox5.Clear();
            }
        }

        
    }
}
