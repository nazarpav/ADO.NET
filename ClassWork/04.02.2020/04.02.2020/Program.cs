using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;

namespace _04._02._2020
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-D4LSJMD\SQLEXPRESS;Initial Catalog=LIBRARY;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            connection.Open();
            SqlCommand command;
            SqlDataReader reader;
            //command = new SqlCommand("SELECT * FROM Books INNER JOIN Languages ON Languages.Id = Books.Language_id WHERE Languages.Language_Name = @Name", connection);
            //Console.WriteLine("Enter LANGUAGE ");
            //command.Parameters.AddWithValue("@Name", Console.ReadLine());
            //reader = command.ExecuteReader();
            //while (reader.Read())
            //{
            //    Console.WriteLine(reader[0] + " | " + reader[1]);
            //}
            //Console.ReadKey();

            //command = new SqlCommand("SELECT B.Book_Name FROM Authors INNER JOIN Books AS B ON B.Author_Id=Authors.Id WHERE Authors.Author_Name=@Name AND Authors.Author_Surname=@Surname", connection);
            //Console.WriteLine("Enter name ");
            //command.Parameters.AddWithValue("@Name", Console.ReadLine());
            //Console.WriteLine("Enter surname ");
            //command.Parameters.AddWithValue("@Surname", Console.ReadLine());
            //reader = command.ExecuteReader();
            //while (reader.Read())
            //{
            //    Console.WriteLine(reader[0]);
            //}

            //command = new SqlCommand("SELECT * FROM Authors WHERE Authors.Age=@Age", connection);
            //Console.WriteLine("Enter Age ");
            //command.Parameters.AddWithValue("@Age", Console.ReadLine());
            //reader = command.ExecuteReader();
            //while (reader.Read())
            //{
            //    Console.WriteLine(reader[0] + "|"+ reader[1]+"|"+reader[2]+"|"+reader[3]);
            //}
            //Console.ReadKey();

            //command = new SqlCommand("SELECT b.Book_Name FROM Books AS b WHERE b.Pages_count =(SELECT MAX(b.Pages_count) FROM Books AS b)", connection);
            //reader = command.ExecuteReader();
            //while (reader.Read())
            //{
            //    Console.WriteLine(reader[0]);
            //}
            //Console.ReadKey();

            //command = new SqlCommand("DELETE FROM Books WHERE Books.Id = @Id", connection);
            //Console.WriteLine("Enter Id ");
            //command.Parameters.AddWithValue("@Id", Console.ReadLine());
            //command.ExecuteNonQuery();
            //Console.ReadKey();

            //command = new SqlCommand("INSERT INTO Books(Book_Name, Author_Id, Language_id, Pages_count) VALUES (@BookName, @AuthorId, @LanguageId, @Pages)", connection);
            //Console.WriteLine("Enter Book Name -> ");
            //command.Parameters.AddWithValue("@BookName", Console.ReadLine());
            //Console.WriteLine("Enter authorId -> ");
            //command.Parameters.AddWithValue("@AuthorId", Console.ReadLine());
            //Console.WriteLine("Enter languageId -> ");
            //command.Parameters.AddWithValue("@LanguageId", Console.ReadLine());
            //Console.WriteLine("Enter Pages -> ");
            //command.Parameters.AddWithValue("@Pages", Console.ReadLine());
            //command.ExecuteReader();
            //Console.ReadKey();
        }
    }
}
/*Показати всі книги конкретної мови (мову вводить користувач)
Показати книги даного автора (по імені та прізвищу)
Показати авторів введеного віку
Отримати назву книги, яка містить найбільшу кількість сторінок
Видалити книгу по Id
Додати книгу в базу*/
//string connectionString = @"Data Source=DESKTOP-D4LSJMD\SQLEXPRESS;Initial Catalog=STSHOP;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
//SqlConnection connection = new SqlConnection(connectionString);
//connection.Open();
//            SqlCommand command = new SqlCommand("insert Product values (@Name,@Qp_Avaible,@Cost,@Manufacturer,@Sale_Price)", connection);
//string str;
//Console.WriteLine("Enter name :");
//            str = Console.ReadLine();
//            command.Parameters.AddWithValue("@Name", str);
//            Console.WriteLine("Enter Qp_Avaible :");
//            str = Console.ReadLine();
//            command.Parameters.AddWithValue("@Qp_Avaible", int.Parse(str));
//            Console.WriteLine("Enter Cost :");
//            str = Console.ReadLine();
//            command.Parameters.AddWithValue("@Cost", int.Parse(str));
//            Console.WriteLine("Enter Manufacturer :");
//            str = Console.ReadLine();
//            command.Parameters.AddWithValue("@Manufacturer", str);
//            Console.WriteLine("Enter Sale Price :");
//            str = Console.ReadLine();
//            command.Parameters.AddWithValue("@Sale_Price", int.Parse(str));
//            SqlDataReader reader = command.ExecuteReader();
//            while (reader.Read())
//            {
//                Console.WriteLine(reader[0] + " | " + reader[1]);
//            }
//            Console.ReadKey();