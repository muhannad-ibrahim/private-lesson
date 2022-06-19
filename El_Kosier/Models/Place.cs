using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace El_Kosier.Models
{
    class Place
    {
        public int id { get; set;}
        public string placeName { get; set; }

        public static void insertPlace(string placeName) {
            SqlConnection cn = new SqlConnection(env.db_con_str);
            cn.Open();
            if (cn.State == System.Data.ConnectionState.Open)
            {

                string query = "insert into place(place_name) values(" + "'" + placeName + "' )";
                SqlCommand cmd = new SqlCommand(query, cn);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (System.Data.SqlClient.SqlException ex)
                {
                    MessageBox.Show("Error during enter the place name");
                }
                cn.Close();

            }
        }

        public static int getPlaceIdByName(string placeName) {
            int placeId;
            SqlConnection cn = new SqlConnection(env.db_con_str);
            cn.Open();
            string query = $"SELECT id FROM place WHERE place_name LIKE '{placeName}' "; ;
            using (SqlCommand cmd = new SqlCommand(query, cn))
            {
                cmd.ExecuteNonQuery();
                placeId = (int)cmd.ExecuteScalar();
                cn.Close();
                return placeId;
            }
        }
    }
}
