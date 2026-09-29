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
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
            customizedesige();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void customizedesige() 
        {
            panel_stu.Visible = false;
            panel_subject.Visible = false;
            panel_resulte.Visible = false;
        
        }
        private void hidesubmeun()
        {
            if (panel_stu.Visible == true)
            {
                panel_stu.Visible = false;
            }
            if (panel_subject.Visible == true)
            {
                panel_subject.Visible = false;
            }
            if (panel_resulte.Visible == true)
            {
                panel_resulte.Visible = false;
            }
        }
        private void showsubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hidesubmeun();
                submenu.Visible = true;
            }
           /* else
            {
                submenu.Visible = false;
            }*/
        
        }

        private void button_std_Click(object sender, EventArgs e)
        {
            showsubmenu(panel_stu);
        }
          #region stdsubmenu

        private void btnstu_Click(object sender, EventArgs e)
        {
            //code the visbale
            hidesubmeun();
            register f = new register();
            f.ShowDialog();
        }

        private void btnmanstu_Click(object sender, EventArgs e)
        {
            //code the visbale
            hidesubmeun();
            mange s = new mange();
            s.ShowDialog();
        }

        private void btnlevelstu_Click(object sender, EventArgs e)
        {
            //code the visbale
            hidesubmeun();
            
        }

        private void printstu_Click(object sender, EventArgs e)
        {
            //code the visbale
            hidesubmeun();
            reporting_student d = new reporting_student();
            d.Show();

        }
          #endregion stdsubmenu
        private void buttoncourse_Click(object sender, EventArgs e)
        {
            showsubmenu(panel_subject);
        }
      
        #region subjectmenu
        private void buttonnewcourse_Click(object sender, EventArgs e)
        {
            //code the visbale
            hidesubmeun();
            course c = new course();
            c.Show();
            
        }

        private void buttonmancourse_Click(object sender, EventArgs e)
        {
            //code the visbale
            hidesubmeun();
            mang_cour s = new mang_cour();
            s.Show();
        }

        private void buttonprintcourse_Click(object sender, EventArgs e)
        {
            //code the visbale
            hidesubmeun();
            report_subject v = new report_subject();
            v.Show();
        }
        #endregion  subjectmenu
        private void buttonresulte_Click(object sender, EventArgs e)
        {
            showsubmenu(panel_resulte);
        }
        #region resultmenu
        private void btnnewresulte_Click(object sender, EventArgs e)
        {
            //code the visbale
            hidesubmeun();
            select_subj s = new select_subj();
            s.Show();
        }

        private void btnmanresult_Click(object sender, EventArgs e)
        {
            //code the visbale
            hidesubmeun();
            mang_result d = new mang_result();
            d.Show();
        }

        private void btnprintresult_Click(object sender, EventArgs e)
        {
            //code the visbale
            hidesubmeun();
           
        }
        #endregion  resultmenu

        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
