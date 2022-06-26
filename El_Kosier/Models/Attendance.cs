using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace El_Kosier.Models
{
    class Attendance
    {
        public int id { get; set; }
        public int classNumber { get; set; }
        public string attendanceType { get; set; }
        public int month { get; set; }

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
    }
}
