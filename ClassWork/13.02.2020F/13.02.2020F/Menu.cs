using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._02._2020F
{
    class Menu
    {
        int choise = 0;
        public  List<menuElement> menu;
        public Menu()
        {
            menu = new List<menuElement>();
            menu.Add(new menuElement(1, "Add book"));
            menu.Add(new menuElement(2, "Show all books"));
            menu.Add(new menuElement(3, "Edit book by id"));
            menu.Add(new menuElement(4, "Delete book by id"));
            menu.Add(new menuElement(0, "Exit"));
        }
        public int Start()
        {
            int choise;
            do
            {
                Console.Clear();
                Console.WriteLine("Enter menu num");
                foreach (var item in menu)
                {
                    Console.WriteLine(item);
                }
            } while (!int.TryParse(Console.ReadLine(), out choise));

            return choise;
        }
    }
}
