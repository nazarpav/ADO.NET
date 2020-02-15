using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _12._02._2020
{
    class CLASS
    {
         List<Good> goods1 = new List<Good>()
            {
            new Good()
            { Id = 1, Title = "Nokia 1100", Price = 450.99M, Category = "Mobile" },
            new Good()
            { Id = 2, Title = "Iphone 4", Price = 5000, Category = "Mobile" },
            new Good()
            { Id = 3, Title = "Refregirator 5000", Price = 2555, Category = "Kitchen" },
            new Good()
            { Id = 4, Title = "Mixer", Price = 150, Category = "Kitchen" },
            new Good()
            { Id = 5, Title = "Magnitola", Price = 1499, Category = "Car" },
          //  };
          //List<Good> goods2 = new List<Good>()
          //  {
            new Good()
            { Id = 6, Title = "Samsung Galaxy", Price = 3100, Category = "Mobile" },
            new Good()
            { Id = 7, Title = "Auto Cleaner", Price = 2300, Category = "Car" },
            new Good()
            { Id = 8, Title = "Owen", Price = 700, Category = "Kitchen" },
            new Good()
            { Id = 9, Title = "Siemens Turbo", Price = 3199, Category = "Mobile" },
            new Good()
            { Id = 10, Title = "Lighter", Price = 150, Category = "Car" }
            };
        public void Start()
        {
            //var selectedTeams = teams.Where(t => t.ToUpper().StartsWith("Б")).OrderBy(t => t);

            var T1 = goods1.Where(t => t.Price > 1000&&t.Category== "Mobile");
            var T2 = goods1.Where(t => t.Category!= "Kitchen"&&t.Price>1000);
            foreach (var item in T2)
            {
                Console.WriteLine(item);
            }
            var T3 = from i in goods1
                     where i.Price == ((from j in goods1 select j.Price).Max())
                     select i;
            foreach (var i in T3)
            {
                Console.WriteLine(i.Title +i.Category);
            }
            var T4 = (from i in goods1 select i.Price).Average();
            Console.WriteLine(T4);
            var T5 = (from i in goods1 select i.Category).Distinct();
            foreach (var item in T5)
            {
                Console.WriteLine(item);
            }
            var T6 = (from i in goods1 select i.Price);

            var T7 = (from i in goods1 orderby i.Title select i.Title);
            foreach (var i in T7)
            {
                Console.WriteLine(i);
            }
            var T8 =  goods1.Where(t => t.Price>1000&&t.Price<2000&&t.Category=="Car").Count()!=0;
            Console.WriteLine(T8?"Yes":"No");
            var T9 = goods1.Where(t => t.Category == "Car" || t.Category == "Mobile").Count();
            Console.WriteLine(T9);

            var T10 = from i in goods1 select "Category : " + i.Category + "Count : " + ((from j in goods1 where j.Category == i.Category select j.Id).Distinct().Count());
            foreach (var i in T10)
            {
                Console.WriteLine(i);
            }
           }

        //1) Выбрать товары категории Mobile, цена которых превышает 1000 грн.
        //2) Вывести название и цену тех товаров, которые не относятся к категории Kitchen,
        //цена которых превышает 1000 грн.
        //3) Вывести название товара и его категорию, который имеет максимальную цену.
        //4) Вычислить среднее значение всех цен товаров.
        //5) Вывести список категорий без повторений.
        //6) Вывести названия тех товаров, цены которых совпадают.
        //7) Вывести названия и категории товаров в алфавитном порядке, упорядоченных по
        //названию.
        //8) Проверить, содержит ли категория Car товары, с ценой от 1000 до 2000 грн.
        //9) Посчитать суммарное количество товаров категорий Сar и Mobile.
        //10) Вывести список категорий и количество товаров каждой категории.
    }
}
