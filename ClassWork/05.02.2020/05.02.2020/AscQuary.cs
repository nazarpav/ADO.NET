using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace _05._02._2020
{
    class AscQuary
    {
        public void Start()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-D4LSJMD\SQLEXPRESS;Initial Catalog=LIBRARY;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;Asynchronous Processing=true");
            connection.Open();
            GetALLAuthors(connection);
        }
        private void GetALLAuthors(SqlConnection connection)
        {
            Thread.Sleep(500);
            SqlCommand command = new SqlCommand("SELECT * FROM Authors", connection);
            AsyncCallback callback = new AsyncCallback(GetDataCallbackAuthors);
        }
        private void GetDataCallbackAuthors(IAsyncResult result)
        {
            SqlDataReader reader = null;

            SqlCommand command = (SqlCommand)result.AsyncState;

            reader = command.EndExecuteReader(result);

            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    Console.Write($"{reader[i]} | ");
                }
                Console.WriteLine();
            }
        }

    }
}
