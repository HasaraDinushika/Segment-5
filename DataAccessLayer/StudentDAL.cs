using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class StudentDAL
    {
        string connectionstring = @"Data Source=(localdb)\Projects;Initial Catalog=Student;Integrated Security=True";

        // Retrieve the data in the database table by using stored procure
        // Fill these data to the datatable
        public DataTable Read()
        {
            using (SqlConnection conn = new SqlConnection(connectionstring))
            using (SqlCommand cmd = new SqlCommand("sp_ReadTableData", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                DataTable dt = new DataTable();
                SqlDataAdapter myAdapter = new SqlDataAdapter(cmd);
                conn.Open();
                myAdapter.Fill(dt);
                return dt;
            }
        }

        // insert data to the database table by calling stored procedure
        public int InsertData(int id, string name, DateTime dateofbirth, decimal gpa, Boolean active)
        {
            using (SqlConnection conn = new SqlConnection(connectionstring))
            using (SqlCommand cmd = new SqlCommand("sp_InsertData", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@dateofbirth", dateofbirth);
                cmd.Parameters.AddWithValue("@gradepointavg", gpa);
                cmd.Parameters.AddWithValue("@active", active);
                conn.Open();
                int noOfRowsAffected = cmd.ExecuteNonQuery();
                return noOfRowsAffected;
            }
        }

        // this function is used to check whether given id is exists in the database table or not
        public bool CheckIDExist(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionstring))
            using (SqlCommand cmd = new SqlCommand("sp_CheckIDExist", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    return true;
                }
                return false;
            }
        }
    }
}




