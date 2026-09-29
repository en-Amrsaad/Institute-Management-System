using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace project.school
{
    class registrationClass
    {
        SqlConnection con;
        SqlCommand com;


        public registrationClass()
        {
            con = new SqlConnection(@"Data Source=AMR;Initial Catalog=school;Integrated Security=True");
        
        }
       
        public void dml(string a)
        {
            con.Open();
            com = new SqlCommand(a, con);
            com.ExecuteNonQuery();
            con.Close();
        }
        
        public DataTable getdata(string a)
        {
            con.Open();
            com = new SqlCommand(a, con);
            com.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;

        }
        


    }


}
