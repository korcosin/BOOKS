using System;
using System.Data.SqlClient;

namespace RoadBook.CsharpBasic.Chapter08.Examples
{
    public class Ex006
    {
        private readonly string connectionStr =
            string.Format("Data Source={0},{1};Initial Catalog={2};User ID={3};Password={4}",
                "127.0.0.1", 1433, "testdb", "sa", "test123!@#");

        public void Run()
        {
            string selectSQL = " SELECT ID, NAME, AGE, JOB FROM TB_USER ";

            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(selectSQL, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Console.WriteLine("회원ID : {0}", reader["ID"]);
                        Console.WriteLine("회원이름 : {0}", reader["NAME"]);
                        Console.WriteLine("회원나이 : {0}", reader["AGE"]);
                        Console.WriteLine("회원직업 : {0}", reader["JOB"]);
                        Console.WriteLine("=====");
                    }
                }
                connection.Close();
            }
        }
    }
}