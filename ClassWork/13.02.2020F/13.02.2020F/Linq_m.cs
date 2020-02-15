using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _13._02._2020F
{
    class Linq_m
    {
        DataClasses1DataContext c;
        Menu menu;
        public Linq_m()
        {
            c = new DataClasses1DataContext();
            menu = new Menu();
        }
        public void Start()
        {
            while (true)
            {
                int choise = menu.Start();
                if (choise == menu.menu[0].number)
                {
                    Console.WriteLine("Enter name:");
                    string BNAME = Console.ReadLine();
                    int AID;
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("Enter author id:");
                        Console.WriteLine("Eror");
                        Thread.Sleep(1000);
                    }
                    while (!int.TryParse(Console.ReadLine(), out AID));
                    int LID;
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("Enter language id:");
                        Console.WriteLine("Eror");
                        Thread.Sleep(1000);
                    }
                    while (!int.TryParse(Console.ReadLine(), out LID));
                    int PCount;
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("Enter pages count:");
                        Console.WriteLine("Eror");
                        Thread.Sleep(1000);
                    }
                    while (!int.TryParse(Console.ReadLine(), out PCount));

                    c.Books.InsertOnSubmit(new Books { Book_Name = BNAME,Author_Id=AID,Language_id=LID,Pages_count=PCount});
                    c.SubmitChanges();
                }
                else if (choise == menu.menu[1].number)
                {
                    var r = from c in c.Books
                            select c;
                    foreach (var i in r)
                    {
                        Console.WriteLine(i.Author_Id + i.Book_Name + i.Languages + i.Language_id + i.Pages_count);
                    }
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (choise == menu.menu[2].number)
                {

                }
                else if (choise == menu.menu[3].number)
                {

                }
                else if (choise == 0)
                {
                    return;
                }
            }
        }
    }
}
