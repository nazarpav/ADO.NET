using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncMethods
{
    enum Tasks
    {
        T1,
        T2
    }
    class Program
    {
        static List<SqlDataReader> RList = new List<SqlDataReader>();
        static Random rnd = new Random();
        static string cs;
        static void Main(string[] args)
        {
        SqlConnection cn = new SqlConnection();
            
            cs = ConfigurationManager.
                    ConnectionStrings["LibraryConnStr"].
                    ConnectionString;
            cn.ConnectionString = cs;
            ///////////Взагалі працює, але якось через раз(і з тестів які я провів виявилося, що краще запускати по одному завданні за раз)
            T1();
            T2();
        }
        static void T1()
        {
            AsyncQuery(cs, "SELECT * FROM Books;", Tasks.T1);
            Thread.Sleep(50);
            AsyncQuery(cs, "SELECT * FROM Authors;", Tasks.T1);
            Thread.Sleep(50);
            AsyncQuery(cs, "SELECT * FROM Readers;", Tasks.T1);
            Thread.Sleep(50);
        }
        static void T2()
        {
            List<WaitHandle> waitHandles = new List<WaitHandle>();
            waitHandles.Add(AsyncQuery(cs, "SELECT * FROM Books;", Tasks.T2).AsyncWaitHandle);
            waitHandles.Add(AsyncQuery(cs, "SELECT * FROM Authors;", Tasks.T2).AsyncWaitHandle);
            waitHandles.Add(AsyncQuery(cs, "SELECT * FROM Readers;", Tasks.T2).AsyncWaitHandle);
            if (WaitHandle.WaitAll(waitHandles.ToArray()))
            {
                Console.WriteLine("-------------------------------------------------------------------------------------------------------------------");
                foreach (var g in RList)
                {
                    while (g.Read())
                    {
                        for (int i = 0; i < g.FieldCount; i++)
                        {
                            Console.Write($"{g[i]} | ");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine("\n------------------------\n");
                }
                foreach (var g in RList)
                {
                    g.Close();
                }
                Thread.Sleep(50);
            }
        }
        static void GetDataCallback2(IAsyncResult result)
        {
            SqlDataReader reader = null;
            try
            {
                SqlCommand command = (SqlCommand)result.AsyncState;
                reader = command.EndExecuteReader(result);
                RList.Add(reader);
                Thread.Sleep(100);
            }
            catch (Exception ex)
            {
                Console.WriteLine("From Callback 1:" + ex.Message);
            }
            finally
            {
            }
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
                Thread.Sleep(100);
                Console.WriteLine("Task_1");
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
        static IAsyncResult AsyncQuery(string cs, string query, Tasks task)
        {
            /// блок 1
            const string AsyncEnabled = "Asynchronous Processing=true";
            if (!cs.Contains(AsyncEnabled))
            {
                cs = string.Format("{0}; {1}", cs, AsyncEnabled);
            }
            var conn = new SqlConnection(cs);
            SqlCommand comm = new SqlCommand();
            comm.Connection = conn;
            comm.CommandText = query;
            comm.CommandType = CommandType.Text;
            comm.CommandTimeout = 30; // sec
            try
            {
                conn.Open();
                AsyncCallback callback;
                if (task==Tasks.T1)
                {
                    callback = new AsyncCallback(GetDataCallback);
                }
                else
                {
                    callback = new AsyncCallback(GetDataCallback2);
                }
                return comm.BeginExecuteReader(callback, comm);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new Exception("Error");
            }
        }
    }
}
