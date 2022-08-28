using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace El_Kosier.Models
{
    class Student
    {
        public static void insertStudent(string studName, int studCode, string grade, string parNum, string notes, string studNum, string enrollDate, int placeId, int groupId)
        {
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

        public static void deleteAllStudents() {
            SqlConnection cn = new SqlConnection(env.db_con_str);
            cn.Open();
            if (cn.State == System.Data.ConnectionState.Open)
            {

                string query = "delete from student";
                SqlCommand cmd = new SqlCommand(query, cn);
                try
                {
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "DBCC CHECKIDENT (student, RESEED, 0)";
                    cmd.ExecuteNonQuery();
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    MessageBox.Show(ex.Errors.ToString());
                }
                cn.Close();
            }
        }

        public static int getMaxStudentCode(int groupId)
        {
            SqlConnection cn = new SqlConnection(env.db_con_str);
            cn.Open();
            string query = $"SELECT MAX(student_code) from student s, \"group\" g WHERE s.group_id=g.id" ;
            SqlCommand cmd = new SqlCommand(query, cn);
            object code = cmd.ExecuteScalar();
            if (code.GetType() == typeof(DBNull))
            {
                cn.Close();
                return 0;
            }
            else
            {
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
            string query = $"SELECT student_code FROM student WHERE student_name LIKE N'{studentName}' ";
            using (SqlCommand cmd = new SqlCommand(query, cn))
            {
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                studentCode = (int)reader.GetValue(0);
                cn.Close();
                return studentCode;
            }
        }

        public static int getStudentIdByName(string studentName)
        {
            int studentId;
            SqlConnection cn = new SqlConnection(env.db_con_str);
            cn.Open();
            string query = $"SELECT id FROM student WHERE student_name LIKE N'{studentName}'";
            using (SqlCommand cmd = new SqlCommand(query, cn))
            {
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                studentId = (int)reader.GetValue(0);
                cn.Close();
                return studentId;
            }
        }

        public static void deleteStudent(int studentId) {
            SqlConnection cn = new SqlConnection(env.db_con_str);
            cn.Open();
            if (cn.State == System.Data.ConnectionState.Open)
            {
                string query = $"delete from student where id = {studentId}";
                SqlCommand cmd = new SqlCommand(query, cn);
                cmd.ExecuteNonQuery();
                cn.Close();
            }
        }

        public static DataTable getAllStudentData()
        {
            using (SqlConnection cn = new SqlConnection(env.db_con_str))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand($"SELECT student_name as 'name', student_code as 'code', student_number as 'student num' , grade , p.place_name as 'place' , g.group_name as 'group' FROM student s, place p , \"group\" g WHERE s.place_id= p.id AND s.group_id = g.id", cn))
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

        public static DataTable getStudentDataWith_Payment(string studentName, int month)
        {
            SqlCommand cmd = new SqlCommand();
            using (SqlConnection cn = new SqlConnection(env.db_con_str))
            {
                cn.Open();
                cmd = new SqlCommand($"SELECT student_name as 'name', student_code as 'code', student_number as 'student num' , grade , p.place_name as 'place' , g.group_name as 'group' FROM student s, place p , \"group\" g , payment m WHERE s.student_name LIKE N'%{studentName}%' AND m.month = {month} AND s.id = m.student_id AND s.place_id= p.id AND s.group_id = g.id", cn);
                using (cmd)
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

        public static DataTable getStudentDataWith_Exam(string studentName, int month)
        {
            SqlCommand cmd = new SqlCommand();
            using (SqlConnection cn = new SqlConnection(env.db_con_str))
            {
                cn.Open();
                cmd = new SqlCommand($"SELECT student_name as 'name', student_code as 'code', student_number as 'student num' , grade , p.place_name as 'place' , g.group_name as 'group' FROM student s, place p , \"group\" g , exam m WHERE s.student_name LIKE N'%{studentName}%' AND m.month = {month} AND s.id = m.student_id AND s.place_id= p.id AND s.group_id = g.id", cn);
                using (cmd)
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

        public static DataTable getStudentDataWith_Attendance(string studentName, int month, int lectureNumber)
        {
            SqlCommand cmd = new SqlCommand();
            using (SqlConnection cn = new SqlConnection(env.db_con_str))
            {
                cn.Open();
                if (lectureNumber == 0)
                {
                    cmd = new SqlCommand($"SELECT student_name as 'name', student_code as 'code', p.place_name as 'place' , g.group_name as 'group', m.attendance_type as 'status', m.class_number as 'lecture number' FROM student s, place p , \"group\" g , attendance m WHERE s.student_name LIKE N'%{studentName}%' AND m.month = {month} AND s.id = m.student_id AND s.place_id= p.id AND s.group_id = g.id", cn);
                }
                else
                {
                    cmd = new SqlCommand($"SELECT student_name as 'name', student_code as 'code', p.place_name as 'place' , g.group_name as 'group', m.attendance_type as 'status' FROM student s, place p , \"group\" g , attendance m WHERE s.student_name LIKE N'%{studentName}%' AND m.month = {month} AND m.class_number = {lectureNumber} AND s.id = m.student_id AND s.place_id= p.id AND s.group_id = g.id", cn);
                }
                
                using (cmd)
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

        public static DataTable getStudentData(string studentName)
        {
            using (SqlConnection cn = new SqlConnection(env.db_con_str))
            {
                cn.Open();
                using (SqlCommand cmd = new SqlCommand($"SELECT student_name as 'name', student_code as 'code', student_number as 'student num' , grade , p.place_name as 'place' , g.group_name as 'group' FROM student s, place p , \"group\" g WHERE student_name LIKE N'%{studentName}%' AND s.place_id= p.id AND s.group_id = g.id", cn))
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
        
        public static DataTable getStudentsPlace_Group(int placeId, int groupId) {
            SqlCommand cmd = new SqlCommand();
            using (SqlConnection cn = new SqlConnection(env.db_con_str))
            {
                cn.Open();
                if (groupId == 0){
                    cmd = new SqlCommand($"SELECT student_name as 'name', student_code as 'code', student_number as 'student num' , grade , p.place_name as 'place' , g.group_name as 'group' FROM student s, place p , \"group\" g WHERE s.place_id = {placeId} AND s.place_id = p.id AND s.group_id = g.id", cn);
                }
                else {
                    cmd = new SqlCommand($"SELECT student_name as 'name', student_code as 'code', student_number as 'student num' , grade , p.place_name as 'place' , g.group_name as 'group' FROM student s, place p , \"group\" g WHERE s.place_id = {placeId} AND s.group_id = {groupId} AND s.place_id = p.id AND s.group_id = g.id", cn);
                }
                using (cmd)
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

        public static DataTable getStudentDataWithPlace_Group(string studentName,int placeId, int groupId) {
            SqlCommand cmd = new SqlCommand();
            using (SqlConnection cn = new SqlConnection(env.db_con_str))
            {
                cn.Open();
                if (groupId == 0) {
                    cmd = new SqlCommand($"SELECT student_name as 'name', student_code as 'code', student_number as 'student num' , grade , p.place_name as 'place' , g.group_name as 'group' FROM student s, place p , \"group\" g WHERE student_name LIKE N'%{studentName}%' AND s.place_id = {placeId} AND s.place_id= p.id AND s.group_id = g.id", cn);
                }
                else {
                    cmd = new SqlCommand($"SELECT student_name as 'name', student_code as 'code', student_number as 'student num' , grade , p.place_name as 'place' , g.group_name as 'group' FROM student s, place p , \"group\" g WHERE student_name LIKE N'%{studentName}%' AND s.place_id = {placeId} AND s.group_id = {groupId} AND s.place_id= p.id AND s.group_id = g.id", cn);
                }
                using (cmd)
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

        public static DataTable getStudentDataWithPlace_Group_Payment(int placeId, int groupId,int month)
        {
            SqlCommand cmd = new SqlCommand();
            using (SqlConnection cn = new SqlConnection(env.db_con_str))
            {
                cn.Open();
                if (groupId == 0){
                    cmd = new SqlCommand($"SELECT student_name as 'name', student_code as 'code', student_number as 'student num' , grade , p.place_name as 'place' , g.group_name as 'group' , m.month FROM student s, place p , \"group\" g , payment m WHERE m.month = {month} AND s.place_id = {placeId} AND s.id = m.student_id AND s.place_id= p.id AND s.group_id = g.id", cn);
                }
                else{
                    cmd = new SqlCommand($"SELECT student_name as 'name', student_code as 'code', student_number as 'student num' , grade , p.place_name as 'place' , g.group_name as 'group' , m.month FROM student s, place p , \"group\" g , payment m WHERE m.month = {month} AND s.place_id = {placeId} AND s.group_id = {groupId} AND s.id = m.student_id AND s.place_id= p.id AND s.group_id = g.id", cn);
                }
                using (cmd)
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
        
        public static DataTable getStudentDataWithPlace_Group_Parment_StudName(string studentName,int placeId, int groupId, int month) {
            SqlCommand cmd = new SqlCommand();
            using (SqlConnection cn = new SqlConnection(env.db_con_str))
            {
                cn.Open();
                if (groupId == 0)
                {
                    cmd = new SqlCommand($"SELECT student_name as 'name', student_code as 'code', student_number as 'student num' , grade , p.place_name as 'place' , g.group_name as 'group' , m.month FROM student s, place p , \"group\" g , payment m WHERE s.student_name LIKE N'%{studentName}%' AND m.month = {month} AND s.place_id = {placeId} AND s.id = m.student_id AND s.place_id= p.id AND s.group_id = g.id", cn);
                }
                else
                {
                    cmd = new SqlCommand($"SELECT student_name as 'name', student_code as 'code', student_number as 'student num' , grade , p.place_name as 'place' , g.group_name as 'group' , m.month FROM student s, place p , \"group\" g , payment m WHERE s.student_name LIKE N'%{studentName}%' AND m.month = {month} AND s.place_id = {placeId} AND s.group_id = {groupId} AND s.id = m.student_id AND s.place_id= p.id AND s.group_id = g.id", cn);
                }
                using (cmd)
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
        
        //IN case user filter by place, group and payment but didn't select a month 
        public static DataTable getAllPayments(int placeId, int groupId)
        {
            SqlCommand cmd = new SqlCommand();
            using (SqlConnection cn = new SqlConnection(env.db_con_str))
            {
                cn.Open();
                if (groupId == 0)
                {
                    cmd = new SqlCommand($"SELECT student_name as 'name', student_code as 'code', student_number as 'student num' , grade , p.place_name as 'place' , g.group_name as 'group' , m.month FROM student s, place p , \"group\" g , payment m WHERE s.place_id = {placeId} AND m.student_id = s.id AND s.place_id= p.id AND s.group_id = g.id", cn);
                }
                else
                {
                    cmd = new SqlCommand($"SELECT student_name as 'name', student_code as 'code', student_number as 'student num' , grade , p.place_name as 'place' , g.group_name as 'group' , m.month FROM student s, place p , \"group\" g , payment m WHERE s.place_id = {placeId} AND s.group_id = {groupId} AND m.student_id = s.id AND s.place_id= p.id AND s.group_id = g.id", cn);
                }
                using (cmd)
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

        //IN case user filter by name,place, group and payment but didn't select a month 
        public static DataTable getAllPayments_studName(string studentName,int placeId, int groupId)
        {
            SqlCommand cmd = new SqlCommand();
            using (SqlConnection cn = new SqlConnection(env.db_con_str))
            {
                cn.Open();
                if (groupId == 0)
                {
                    cmd = new SqlCommand($"SELECT student_name as 'name', student_code as 'code', student_number as 'student num' , grade , p.place_name as 'place' , g.group_name as 'group' , m.month FROM student s, place p , \"group\" g , payment m WHERE s.student_name LIKE N'%{studentName}%' AND s.place_id = {placeId} AND m.student_id = s.id AND s.place_id= p.id AND s.group_id = g.id", cn);
                }
                else
                {
                    cmd = new SqlCommand($"SELECT student_name as 'name', student_code as 'code', student_number as 'student num' , grade , p.place_name as 'place' , g.group_name as 'group' , m.month FROM student s, place p , \"group\" g , payment m WHERE s.student_name LIKE N'%{studentName}%' AND s.place_id = {placeId} AND s.group_id = {groupId} AND m.student_id = s.id AND s.place_id= p.id AND s.group_id = g.id", cn);
                }
                using (cmd)
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

        public static DataTable getStudentDataWithPlace_Group_Exam(int placeId, int groupId, int month)
        {
            SqlCommand cmd = new SqlCommand();
            using (SqlConnection cn = new SqlConnection(env.db_con_str))
            {
                cn.Open();
                if (groupId == 0){
                    cmd = new SqlCommand($"SELECT student_name as 'name', student_code as 'code', student_number as 'student num' , grade , p.place_name as 'place' , g.group_name as 'group' , m.result FROM student s, place p , \"group\" g , exam m WHERE m.month = {month} AND s.place_id = {placeId} AND s.id = m.student_id AND s.place_id= p.id AND s.group_id = g.id", cn);
                }
                else{
                    cmd = new SqlCommand($"SELECT student_name as 'name', student_code as 'code', student_number as 'student num' , grade , p.place_name as 'place' , g.group_name as 'group' , m.result FROM student s, place p , \"group\" g , exam m WHERE m.month = {month} AND s.place_id = {placeId} AND s.group_id = {groupId} AND s.id = m.student_id AND s.place_id= p.id AND s.group_id = g.id", cn);
                }
                using (cmd)
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

        public static DataTable getStudentDataWithPlace_Group_Exam_studenName(string studentName,int placeId, int groupId, int month)
        {
            SqlCommand cmd = new SqlCommand();
            using (SqlConnection cn = new SqlConnection(env.db_con_str))
            {
                cn.Open();
                if (groupId == 0)
                {
                    cmd = new SqlCommand($"SELECT student_name as 'name', student_code as 'code', student_number as 'student num' , grade , p.place_name as 'place' , g.group_name as 'group' , m.result FROM student s, place p , \"group\" g , exam m WHERE s.student_name LIKE N'%{studentName}%' AND  m.month = {month} AND s.place_id = {placeId} AND s.id = m.student_id AND s.place_id= p.id AND s.group_id = g.id", cn);
                }
                else
                {
                    cmd = new SqlCommand($"SELECT student_name as 'name', student_code as 'code', student_number as 'student num' , grade , p.place_name as 'place' , g.group_name as 'group' , m.result FROM student s, place p , \"group\" g , exam m WHERE s.student_name LIKE N'%{studentName}%' AND m.month = {month} AND s.place_id = {placeId} AND s.group_id = {groupId} AND s.id = m.student_id AND s.place_id= p.id AND s.group_id = g.id", cn);
                }
                using (cmd)
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

        //IN case user filter by place, group and exam but didn't select a month 
        public static DataTable getAllExams(int placeId, int groupId)
        {
            SqlCommand cmd = new SqlCommand();
            using (SqlConnection cn = new SqlConnection(env.db_con_str))
            {
                cn.Open();
                if (groupId == 0)
                {
                    cmd = new SqlCommand($"SELECT student_name as 'name', student_code as 'code', student_number as 'student num' , grade , p.place_name as 'place' , g.group_name as 'group' , m.result FROM student s, place p , \"group\" g , exam m WHERE s.place_id = {placeId} AND s.id = m.student_id AND s.place_id= p.id AND s.group_id = g.id", cn);
                }
                else
                {
                    cmd = new SqlCommand($"SELECT student_name as 'name', student_code as 'code', student_number as 'student num' , grade , p.place_name as 'place' , g.group_name as 'group' , m.result FROM student s, place p , \"group\" g , exam m WHERE s.place_id = {placeId} AND s.group_id = {groupId} AND s.id = m.student_id AND s.place_id= p.id AND s.group_id = g.id", cn);
                }
                using (cmd)
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

        //IN case user filter by name,place, group and exam but didn't select a month 
        public static DataTable getAllExams_studName(string studentName,int placeId, int groupId)
        {
            SqlCommand cmd = new SqlCommand();
            using (SqlConnection cn = new SqlConnection(env.db_con_str))
            {
                cn.Open();
                if (groupId == 0)
                {
                    cmd = new SqlCommand($"SELECT student_name as 'name', student_code as 'code', student_number as 'student num' , grade , p.place_name as 'place' , g.group_name as 'group' , m.result FROM student s, place p , \"group\" g , exam m WHERE s.student_name LIKE N'%{studentName}%' AND s.place_id = {placeId} AND s.id = m.student_id AND s.place_id= p.id AND s.group_id = g.id", cn);
                }
                else
                {
                    cmd = new SqlCommand($"SELECT student_name as 'name', student_code as 'code', student_number as 'student num' , grade , p.place_name as 'place' , g.group_name as 'group' , m.result FROM student s, place p , \"group\" g , exam m WHERE s.student_name LIKE N'%{studentName}%' AND s.place_id = {placeId} AND s.group_id = {groupId} AND s.id = m.student_id AND s.place_id= p.id AND s.group_id = g.id", cn);
                }
                using (cmd)
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

        public static DataTable getStudentDataWithPlace_Group_Attendace(int placeId, int groupId, int month, int lectureNumber) {
            SqlCommand cmd = new SqlCommand();
            using (SqlConnection cn = new SqlConnection(env.db_con_str))
            {
                cn.Open();
                if (groupId == 0)
                {
                    if (lectureNumber == 0)
                    {
                        cmd = new SqlCommand($"SELECT student_name as 'name', student_code as 'code', g.group_name as 'group' , m.month , m.attendance_type as 'status', m.class_number as 'lecture number' FROM student s, place p , \"group\" g , attendance m WHERE m.month = {month} AND s.place_id = {placeId} AND s.id = m.student_id AND s.place_id= p.id AND s.group_id = g.id", cn);
                    }
                    else
                    {
                        cmd = new SqlCommand($"SELECT student_name as 'name', student_code as 'code', g.group_name as 'group' , m.month , m.attendance_type as 'status', m.class_number as 'lecture number' FROM student s, place p , \"group\" g , attendance m WHERE m.month = {month} AND s.place_id = {placeId} AND m.class_number = {lectureNumber} AND s.id = m.student_id AND s.place_id= p.id AND s.group_id = g.id", cn);
                    }
                }
                else
                {
                    if (lectureNumber == 0)
                    {
                        cmd = new SqlCommand($"SELECT student_name as 'name', student_code as 'code', g.group_name as 'group' , m.month , m.attendance_type as 'status' , m.class_number as 'lecture number' FROM student s, place p , \"group\" g , attendance m WHERE m.month = {month} AND s.place_id = {placeId} AND s.group_id = {groupId} AND s.id = m.student_id AND s.place_id= p.id AND s.group_id = g.id", cn);
                    }
                    else
                    {
                        cmd = new SqlCommand($"SELECT student_name as 'name', student_code as 'code', g.group_name as 'group' , m.month , m.attendance_type as 'status' , m.class_number as 'lecture number' FROM student s, place p , \"group\" g , attendance m WHERE m.month = {month} AND s.place_id = {placeId} AND s.group_id = {groupId} AND m.class_number = {lectureNumber} AND s.id = m.student_id AND s.place_id= p.id AND s.group_id = g.id", cn);
                    }
                    
                }
                using (cmd)
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

        public static DataTable getStudentDataWithPlace_Group_Attendace_studName(string studentName, int placeId, int groupId, int month, int lectureNumber)
        {
            SqlCommand cmd = new SqlCommand();
            using (SqlConnection cn = new SqlConnection(env.db_con_str))
            {
                cn.Open();
                if (groupId == 0)
                {
                    if (lectureNumber == 0)
                    {
                        cmd = new SqlCommand($"SELECT student_name as 'name', student_code as 'code', g.group_name as 'group' , m.month , m.attendance_type as 'status', m.class_number as 'lecture number' FROM student s, place p , \"group\" g , attendance m WHERE s.student_name LIKE N'%{studentName}%' AND  m.month = {month} AND s.place_id = {placeId} AND s.id = m.student_id AND s.place_id= p.id AND s.group_id = g.id", cn);
                    }
                    else
                    {
                        cmd = new SqlCommand($"SELECT student_name as 'name', student_code as 'code', g.group_name as 'group' , m.month , m.attendance_type as 'status', m.class_number as 'lecture number' FROM student s, place p , \"group\" g , attendance m WHERE s.student_name LIKE N'%{studentName}%' AND  m.month = {month} AND s.place_id = {placeId} AND m.class_number = {lectureNumber} AND s.id = m.student_id AND s.place_id= p.id AND s.group_id = g.id", cn);
                    }
                }
                else
                {
                    if (lectureNumber == 0)
                    {
                        cmd = new SqlCommand($"SELECT student_name as 'name', student_code as 'code', g.group_name as 'group' , m.month , m.attendance_type as 'status' , m.class_number as 'lecture number' FROM student s, place p , \"group\" g , attendance m WHERE s.student_name LIKE N'%{studentName}%' AND  m.month = {month} AND s.place_id = {placeId} AND s.group_id = {groupId} AND s.id = m.student_id AND s.place_id= p.id AND s.group_id = g.id", cn);
                    }
                    else
                    {
                        cmd = new SqlCommand($"SELECT student_name as 'name', student_code as 'code', g.group_name as 'group' , m.month , m.attendance_type as 'status' , m.class_number as 'lecture number' FROM student s, place p , \"group\" g , attendance m WHERE s.student_name LIKE N'%{studentName}%' AND m.month = {month} AND s.place_id = {placeId} AND s.group_id = {groupId} AND m.class_number = {lectureNumber} AND s.id = m.student_id AND s.place_id= p.id AND s.group_id = g.id", cn);
                    }

                }
                using (cmd)
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

        //IN case user filter by place, group and attenance but didn't select a month 
        public static DataTable getAllAttendace(int placeId, int groupId)
        {
            SqlCommand cmd = new SqlCommand();
            using (SqlConnection cn = new SqlConnection(env.db_con_str))
            {
                cn.Open();
                if (groupId == 0)
                {
                    cmd = new SqlCommand($"SELECT student_name as 'name', student_code as 'code', g.group_name as 'group' , m.month , m.attendance_type as 'status' , m.class_number as 'lecture number' FROM student s, place p , \"group\" g , Attendance m WHERE s.place_id = {placeId} AND s.id = m.student_id AND s.place_id= p.id AND s.group_id = g.id", cn);
                }
                else
                {
                    cmd = new SqlCommand($"SELECT student_name as 'name', student_code as 'code', g.group_name as 'group' , m.month , m.attendance_type as 'status', m.class_number as 'lecture number' FROM student s, place p , \"group\" g , Attendance m WHERE s.place_id = {placeId} AND s.group_id = {groupId} AND s.id = m.student_id AND s.place_id= p.id AND s.group_id = g.id", cn);
                }
                using (cmd)
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

        //IN case user filter by name,place, group and attenance but didn't select a month 
        public static DataTable getAllAttendace_studName(string studentName,int placeId, int groupId)
        {
            SqlCommand cmd = new SqlCommand();
            using (SqlConnection cn = new SqlConnection(env.db_con_str))
            {
                cn.Open();
                if (groupId == 0)
                {
                    cmd = new SqlCommand($"SELECT student_name as 'name', student_code as 'code', g.group_name as 'group' , m.month , m.attendance_type as 'status' , m.class_number as 'lecture number' FROM student s, place p , \"group\" g , Attendance m WHERE s.place_id = {placeId} AND s.id = m.student_id AND s.place_id= p.id AND s.group_id = g.id", cn);
                }
                else
                {
                    cmd = new SqlCommand($"SELECT student_name as 'name', student_code as 'code', g.group_name as 'group' , m.month , m.attendance_type as 'status', m.class_number as 'lecture number' FROM student s, place p , \"group\" g , Attendance m WHERE s.place_id = {placeId} AND s.group_id = {groupId} AND s.id = m.student_id AND s.place_id= p.id AND s.group_id = g.id", cn);
                }
                using (cmd)
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
}
