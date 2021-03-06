﻿using System;
using System.Data;
using System.Data.SqlClient;

namespace _05._02._2020
{
    class Program
    {
        static void Main(string[] args)
        {
            AscQuary AS = new AscQuary();
            AS.Start();

            Console.ReadKey();

        }
        static void GetDataCallback(IAsyncResult result)
        {
            SqlDataReader reader = null;
            try
            {
                /// блок 1
                SqlCommand command = (SqlCommand)result.AsyncState;
                /// блок 2

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
            catch (Exception ex)
            {
                Console.WriteLine("From Callback 1:" + ex.Message);
            }
            finally
            {
                try
                {
                    if (!reader.IsClosed)
                        reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("From Callback 2" + ex.Message);
                }
            }
        }
        static void AsyncQuery(string cs)
        {
            /// блок 1
            const string AsyncEnabled = "Asynchronous Processing=true";
            if (!cs.Contains(AsyncEnabled))
            {
                cs = String.Format("{0}; {1}", cs, AsyncEnabled);
            }

            var conn = new SqlConnection(cs);
            SqlCommand comm = new SqlCommand();
            comm.Connection = conn;
            /// блок 2
            comm.CommandText = "WAITFOR DELAY /00:00:05/; SELECT * FROM Books;";
            comm.CommandType = CommandType.Text;
            comm.CommandTimeout = 30; // sec
            ///
            try
            {
                conn.Open();
                /// блок 3
                AsyncCallback callback = new AsyncCallback(GetDataCallback);
                comm.BeginExecuteReader(callback, comm);

                Console.WriteLine("Added thread is working...");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        
    }
}
