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
        public static void insertPlace(string placeName) {
            SqlConnection cn = new SqlConnection(env.db_con_str);
            cn.Open();
            if (cn.State == System.Data.ConnectionState.Open)
            {

                string query = "insert into place(place_name) values( N'" + placeName + "' )";
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

        public static void deleteAllPlaces()
        {
            SqlConnection cn = new SqlConnection(env.db_con_str);
            cn.Open();
            if (cn.State == System.Data.ConnectionState.Open)
            {

                string query = "delete from place";
                SqlCommand cmd = new SqlCommand(query, cn);
                try
                {
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "DBCC CHECKIDENT (place, RESEED, 0)";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = "DBCC CHECKIDENT (\"group\", RESEED, 0)";
                    cmd.ExecuteNonQuery();
                }

                catch (System.Data.SqlClient.SqlException ex)
                {
                    MessageBox.Show(ex.Errors.ToString());
                }
                cn.Close();
            }
        }

        public static List<string> getAllplacesName() {
            List<string> placesName = new List<string>();
            SqlConnection cn = new SqlConnection(env.db_con_str);
            cn.Open();
            string query = "SELECT place_name FROM place";
            using (SqlCommand cmd = new SqlCommand(query, cn))
            {
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    placesName.Add(reader.GetValue(0).ToString());
                }
                cn.Close();
                return placesName;
            }
        }

        public static int getPlaceIdByName(string placeName) {
            int placeId;
            SqlConnection cn = new SqlConnection(env.db_con_str);
            cn.Open();
            string query = $"SELECT id FROM place WHERE place_name LIKE '{placeName}' ";
            using (SqlCommand cmd = new SqlCommand(query, cn))
            {
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                placeId = (int)reader.GetValue(0);
                cn.Close();
                return placeId;
            }
        }

        public static string getPlaceNameById(int placeId)
        {
            string placeName;
            SqlConnection cn = new SqlConnection(env.db_con_str);
            cn.Open();
            string query = $"SELECT place_name FROM place WHERE id = {placeId}";
            using (SqlCommand cmd = new SqlCommand(query, cn))
            {
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                placeName = reader.GetValue(0).ToString();
                cn.Close();
                return placeName;
            }
        }
    }
}
