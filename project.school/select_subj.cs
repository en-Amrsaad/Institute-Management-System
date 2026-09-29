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
    public partial class select_subj : Form
    {
        public select_subj()
        {
            InitializeComponent();
        }
        registrationClass d = new registrationClass();
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void select_subj_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = d.getdata("select id,f_name from regist_table ");
            comboBox1.DisplayMember = "f_name";
            comboBox1.ValueMember = "id";
            dataGridView1.DataSource = d.getdata("select id_cou as'المعرف',name_cou as'اسم المادة',price_cou'السعر'from Table_cou");


        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++) {
                if (Convert.ToBoolean(dataGridView1.Rows[i].Cells[0].Value) == true)
                {
                    d.dml("insert into show_table values('" + comboBox1.SelectedValue + "','" + dataGridView1.Rows[i].Cells[1].Value + "','" + dataGridView1.Rows[i].Cells[3].Value + "',getdate())");
                    dataGridView1.Rows[i].Cells[0].Value = false;
                    MessageBox.Show("Registered Successfully");


                }
            }

        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int t=0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dataGridView1.Rows[i].Cells[0].Value) == true)
                {
                    t = t + Convert.ToUInt16(dataGridView1.Rows[i].Cells[3].Value);

                }
            }
            label3.Text = t.ToString();
        }
    }
}
