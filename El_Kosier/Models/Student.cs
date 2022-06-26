using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace El_Kosier.Models
{
    class Student
    {
        public int id { get; set; }
        public string studentName { get; set; }
        public int studentCode { get; set; }
        public string grade { get; set; }
        public string parentNumber { get; set; }
        public string notes { get; set; }
        public string studentNumber { get; set; }
        public string enrollDate { get; set; }

        public static void insertStudent(string studName,int studCode,string grade,string parNum,string notes,string studNum,string enrollDate,int placeId,int groupId) {
            SqlConnection cn = new SqlConnection(env.db_con_str);
            cn.Open();
            if (cn.State == System.Data.ConnectionState.Open)
            {
                
                string query = "insert into student(student_name,student_code,grade,parent_number,notes,place_id,group_id,student_number,enroll_date) values(" + "N'" + studName + "' , '" + studCode + "' , '" + grade + "' , '" + parNum + "' , N'" + notes + "' , '" + placeId + "' , '" + groupId + "' , '" + studNum + "' , '" + enrollDate + "' )";
                SqlCommand cmd = new SqlCommand(query, cn);
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Done");
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    int SQL_UNIQUE_KEY_VIOLATION = -2146232060;
                    if (ex.ErrorCode == SQL_UNIQUE_KEY_VIOLATION)
                    {
                        MessageBox.Show("student Code already exists!");
                        return;
                    }
                }
                cn.Close();
                
            }
        }

        public static int getMaxStudentCode() {
            SqlConnection cn = new SqlConnection(env.db_con_str);
            cn.Open();
            string query = "SELECT MAX(student_code) from student";
            SqlCommand cmd = new SqlCommand(query, cn);
            object code = cmd.ExecuteScalar();
            if (code.GetType() == typeof(DBNull)) {
                cn.Close();
                return 0;
            }
            else {
                int maxCode = (int)code;
                cn.Close();
                return maxCode;
            }
        }

        public static List<string> getAllStudentName()
        {
            List<string> studentsName = new List<string>();
            SqlConnection cn = new SqlConnection(env.db_con_str);
            cn.Open();
            string query = "SELECT student_name FROM student";
            using (SqlCommand cmd = new SqlCommand(query, cn))
            {
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    studentsName.Add(reader.GetValue(0).ToString());
                }
                cn.Close();
                return studentsName;
            }
        }

        public static int getStudentCodeByName(string studentName)
        {
            int studentCode;
            SqlConnection cn = new SqlConnection(env.db_con_str);
            cn.Open();
            string query = $"SELECT student_code FROM student WHERE student_name LIKE '{studentName}' ";
            using (SqlCommand cmd = new SqlCommand(query, cn))
            {
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                studentCode = (int)reader.GetValue(0);
                cn.Close();
                return studentCode;
            }
        }

        public static int getStudentIdByName(string studentName) {
            int studentId;
            SqlConnection cn = new SqlConnection(env.db_con_str);
            cn.Open();
            string query = $"SELECT id FROM student WHERE student_name LIKE '{studentName}' ";
            using (SqlCommand cmd = new SqlCommand(query, cn))
            {
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                studentId = (int)reader.GetValue(0);
                cn.Close();
                return studentId;
            }
        }
    }
}
