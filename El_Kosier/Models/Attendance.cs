using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace El_Kosier.Models
{
    class Attendance
    {
        public static void inertAttendeance(int classNumber , int month, string attendanceType, int studentId)
        {
            SqlConnection cn = new SqlConnection(env.db_con_str);
            cn.Open();
            if (cn.State == System.Data.ConnectionState.Open)
            {

                string query = "insert into attendance (class_number,attendance_type, month ,student_id) values( '" + classNumber + " ',' " + attendanceType + " ',' " + month + " ',' " + studentId + "' )";
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

        public static DataTable getAttendanceById(int studentId)
        {
            SqlConnection cn = new SqlConnection(env.db_con_str);
            cn.Open();
            string query = $"SELECT month, class_number as 'lecture number', attendance_type as 'attendance' FROM attendance WHERE student_id = {studentId}";
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
