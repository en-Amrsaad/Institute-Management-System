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
    public partial class report_subject : Form
    {
        public report_subject()
        {
            InitializeComponent();
        }
        registrationClass d = new registrationClass();
        private void report_subject_Load(object sender, EventArgs e)
        {
            CrystalReport2 n = new CrystalReport2();
            n.SetDataSource(d.getdata("select * from Table_cou "));
            crystalReportViewer1.ReportSource = n;
        }
    }
}
