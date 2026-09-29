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
    public partial class mang_cour : Form
    {
        public mang_cour()
        {
            InitializeComponent();
        }
        registrationClass d = new registrationClass();
        private void mang_cour_Load(object sender, EventArgs e)
        {
            data();
        }

        private void data()
        {
            dataGridView1.DataSource = d.getdata("select id_cou as'المعرف',name_cou as'اسم المادة',Hour_cou as'ساعات الدراسة',price_cou as'السعر' from Table_cou");

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                textBox4.Text = row.Cells["المعرف"].Value.ToString();
                textBox1.Text = row.Cells["اسم المادة"].Value.ToString();
                textBox2.Text = row.Cells["ساعات الدراسة"].Value.ToString();
                textBox3.Text = row.Cells["السعر"].Value.ToString();
            }
        }

        private void btnupd_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure about the Update", "system message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                d.dml("update Table_cou set name_cou = N'" + textBox1.Text + "',Hour_cou =N'" + textBox2.Text + "',price_cou =N'" + textBox3.Text + "' where id_cou ='" + textBox4.Text + "'");
                MessageBox.Show("The update is done", "system message",MessageBoxButtons.OK,MessageBoxIcon.Information);
                data();
            }
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = d.getdata(" select id_cou as'المعرف',name_cou as'اسم المادة',Hour_cou as'ساعات الدراسة',price_cou as'السعر' from Table_cou  where name_cou like N'%" + textBox5.Text + "%'order by id_cou");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure about the deletion", "system message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
            d.dml("delete from Table_cou where id_cou="+textBox4.Text+" ");
            MessageBox.Show("The delete is done", "system message",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            }
        }
    }
}
