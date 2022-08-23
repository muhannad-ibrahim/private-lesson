using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace El_Kosier.Models
{
    class Exam
    {
        public static void inertExamRes(string result, int month, int studentId)
        {
            SqlConnection cn = new SqlConnection(env.db_con_str);
            cn.Open();
            if (cn.State == System.Data.ConnectionState.Open)
            {

                string query = "insert into exam (month,result,student_id) values( '" + month + " ',' " + result + " ',' " + studentId + "' )";
                SqlCommand cmd = new SqlCommand(query, cn);
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Done !");
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    MessageBox.Show(ex.Errors.ToString());
                }
                cn.Close();

            }
        }

        public static DataTable getExamById(int studentId)
        {
            int month;
            SqlConnection cn = new SqlConnection(env.db_con_str);
            cn.Open();
            string query = $"SELECT month, result FROM exam WHERE student_id = {studentId}";
            using (SqlCommand cmd = new SqlCommand(query, cn))
            {
                DataTable dt = new DataTable();
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
                cn.Close();
                return dt;
            }
        }
    }
}
