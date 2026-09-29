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
    public partial class reporting_student : Form
    {
        public reporting_student()
        {
            InitializeComponent();
        }
        registrationClass d = new registrationClass();

        private void reporting_student_Load(object sender, EventArgs e)
        {
            CrystalReport1 n = new CrystalReport1();
            n.SetDataSource(d.getdata("select * from regist_table "));
            crystalReportViewer1.ReportSource = n;
            
        }
    }
}
