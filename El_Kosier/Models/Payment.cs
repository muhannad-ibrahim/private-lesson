using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace El_Kosier.Models
{
    class Payment
    {
        public int id { get; set; }
        public int month { get; set; }

        public static void insertPayment(int month, int studentId) {
            SqlConnection cn = new SqlConnection(env.db_con_str);
            cn.Open();
            if (cn.State == System.Data.ConnectionState.Open)
            {

                string query = "insert into payment (month,student_id) values(" + "'" + month + " ',' " + studentId + "' )";
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
