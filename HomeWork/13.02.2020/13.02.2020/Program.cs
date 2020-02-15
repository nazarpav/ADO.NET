using System;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._02._2020
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-D4LSJMD\SQLEXPRESS;Initial Catalog=LIBRARY_;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            connection.Open();
            //T1(connection);


            //T2(connection);



            //T3(connection);



            //T4(connection);


            T5(connection);



            connection.Close();
            Console.ReadKey();
        }
        public static void T1(SqlConnection connection)
        {
            SqlCommand command = new SqlCommand("select * from Readers where Readers.IsDebtor=1",connection);
            var res=command.ExecuteReader();
            while (res.Read())
            {
                for (int i = 0; i < res.FieldCount; i++)
                {
                    Console.Write($"{res[i]} | ");
                }
                Console.WriteLine();
            }

        }
        public static void T2(SqlConnection connection)
        {
            SqlCommand command = new SqlCommand("SELECT Authors_.[Name] FROM (SELECT ROW_NUMBER() OVER (ORDER BY Id ASC) AS rownumber, Id as ID_ FROM Books)AS F INNER JOIN Books_Authors ON Books_Authors.Book_Id = rownumber INNER JOIN Authors AS Authors_ ON Authors_.Id = ID_  WHERE rownumber =3", connection);
            var res = command.ExecuteReader();
            while (res.Read())
            {
                for (int i = 0; i < res.FieldCount; i++)
                {
                    Console.Write($"{res[i]} | ");
                }
                Console.WriteLine();
            }

        }

        public static void T3(SqlConnection connection)
        {
            SqlCommand command = new SqlCommand("SELECT * FROM Books WHERE Books.IsAvailable=1", connection);
            var res = command.ExecuteReader();
            while (res.Read())
            {
                for (int i = 0; i < res.FieldCount; i++)
                {
                    Console.Write($"{res[i]} | ");
                }
                Console.WriteLine();
            }

        }
        public static void T4(SqlConnection connection)
        {
            SqlCommand command = new SqlCommand("SELECT BOOKS_.[Name] FROM ( SELECT ROW_NUMBER() OVER (ORDER BY Id ASC) AS rownumber, Id as ID_ FROM Readers)AS F INNER JOIN Book_Readers ON Book_Readers.Reader_Id = ID_ INNER JOIN Books AS BOOKS_ ON BOOKS_.Id=Book_Readers.Book_Id WHERE rownumber = 2", connection);
            var res = command.ExecuteReader();
            while (res.Read())
            {
                for (int i = 0; i < res.FieldCount; i++)
                {
                    Console.Write($"{res[i]} | ");
                }
                Console.WriteLine();
            }

        }

        public static void T5(SqlConnection connection)
        {
            SqlCommand command = new SqlCommand("UPDATE Readers SET IsDebtor=0", connection);
            var res = command.ExecuteReader();
            while (res.Read())
            {
                for (int i = 0; i < res.FieldCount; i++)
                {
                    Console.Write($"{res[i]} | ");
                }
                Console.WriteLine();
            }

        }
    }
}
