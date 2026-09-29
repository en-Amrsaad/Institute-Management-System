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
    public partial class mang_result : Form
    {
        public mang_result()
        {
            InitializeComponent();
        }
        registrationClass s = new registrationClass();
        private void mang_result_Load(object sender, EventArgs e)
        {
          //  dataGridView1.DataSource = s.getdata("select id as'المعرف',(select f_name from regist_table where id=[show_table].id_student )as'اسم الطالب ',(select name_cou from Table_cou where id_cou=[show_table].id_subject)as'اسم المادة',price as'السعر',getdate() as'التاريخ' from show_table order by id desc ");
            dataGridView1.DataSource = s.getdata(@"SELECT  [id] as'المعرف'
      ,[f_name] as'اسم الاول'
      ,[l_name] as'الاسم الثاني'
      ,[name_cou] as'اسم المادة'
      ,[price_cou] as'سعرالمادة'
      ,[data] as'التاريخ'
      ,[gender] as'الجنس'
  FROM [school].[dbo].[showproject\] order by [id] ");
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
           // dataGridView1.DataSource = s.getdata("select id as'المعرف',(select f_name from regist_table where id=[show_table].id_student )as'اسم الطالب ',(select name_cou from Table_cou where id_cou=[show_table].id_subject)as'اسم المادة',price as'السعر',getdate() as'التاريخ' from show_table where f_name like '%"+textBox4.Text+"%' order by id desc");
            dataGridView1.DataSource = s.getdata(@"SELECT  [id] as'المعرف'
      ,[f_name] as'اسم الطالب'
      ,[l_name] as'الاسم الثاني'
      ,[name_cou] as'اسم المادة'
      ,[price_cou] as'سعرالمادة'
      ,[data] as'التاريخ'
      ,[gender] as'الجنس'
  FROM [school].[dbo].[showproject\] where f_name like N'%" + textBox4.Text+"%' order by [id] ");
        }
    }
}
