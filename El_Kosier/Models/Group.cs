using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace El_Kosier.Models
{
    class Group
    {
        public int id { get; set; }
        public string groupName { get; set; }

        public static void insertGroup(string groupName, int placeId)
        {
            SqlConnection cn = new SqlConnection(env.db_con_str);
            cn.Open();
            if (cn.State == System.Data.ConnectionState.Open)
            {

                string query = "insert into \"group\" (group_name,place_id) values(" + "'" + groupName + " ',' " + placeId + "' )";
                SqlCommand cmd = new SqlCommand(query, cn);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    MessageBox.Show(ex.Errors.ToString());
                }
                cn.Close();

            }
        }

        public static int getGroupIdByName(string groupName)
        {
            int groupId;
            SqlConnection cn = new SqlConnection(env.db_con_str);
            cn.Open();
            string query = $"SELECT id FROM \"group\" WHERE group_name =  {groupName}"; ;
            using (SqlCommand cmd = new SqlCommand(query, cn))
            {
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                groupId = (int)reader.GetValue(0);
                cn.Close();
                return groupId;
            }
        }
    }
}
