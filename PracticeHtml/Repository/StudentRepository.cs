using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace PracticeHtml.Repository
{
    public class StudentRepository
    {
        public string getStudent = "select top 1 name from Student";


        public string GetFirstStudentName()
        {

            string name = string.Empty;

            var connectionString = ConnectionString.GetConnectionString();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(getStudent, connection);

                try
                {
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        name = reader[0].ToString();

                    }
                    reader.Close();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                return name;
            }
        }

    }
}