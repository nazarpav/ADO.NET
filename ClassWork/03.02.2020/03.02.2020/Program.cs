using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace _03._02._2020
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = @"Data Source=DESKTOP-D4LSJMD\SQLEXPRESS;Initial Catalog=STSHOP;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            SqlCommand command = new SqlCommand("insert Product values (@Name,@Qp_Avaible,@Cost,@Manufacturer,@Sale_Price)",connection);
            string str;
            Console.WriteLine("Enter name :");
            str = Console.ReadLine();
            command.Parameters.AddWithValue("@Name", str);
            Console.WriteLine("Enter Qp_Avaible :");
            str = Console.ReadLine();
            command.Parameters.AddWithValue("@Qp_Avaible", int.Parse(str));
            Console.WriteLine("Enter Cost :");
            str = Console.ReadLine();
            command.Parameters.AddWithValue("@Cost", int.Parse(str));
            Console.WriteLine("Enter Manufacturer :");
            str = Console.ReadLine();
            command.Parameters.AddWithValue("@Manufacturer", str);
            Console.WriteLine("Enter Sale Price :");
            str = Console.ReadLine();
            command.Parameters.AddWithValue("@Sale_Price", int.Parse(str));

            SqlDataReader reader = command.ExecuteReader();
            
            while (reader.Read())
            {
                Console.WriteLine(reader[0] + " | " + reader[1]);
            }



            Console.ReadKey();
        }
    }
}
