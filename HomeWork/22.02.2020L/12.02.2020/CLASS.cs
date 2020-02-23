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

            //var T1 = goods1.Where(t => t.Price > 1000&&t.Category== "Mobile");
            ///////////////////////////////////////////////////////////////////////////////////////
            //var T2 = goods1.Where(t => t.Category!= "Kitchen"&&t.Price>1000);
            //foreach (var item in T2)
            //{
            //    Console.WriteLine(item);
            //}
            ///////////////////////////////////////////////////////////////////////////////////////

            //var T3 = from i in goods1
            //         where i.Price == ((from j in goods1 select j.Price).Max())
            //         select i;
            //foreach (var i in T3)
            //{
            //    Console.WriteLine(i.Title +i.Category);
            //}
            ///////////////////////////////////////////////////////////////////////////////////////

            //var T4 = (from i in goods1 select i.Price).Average();
            //Console.WriteLine(T4);
            ///////////////////////////////////////////////////////////////////////////////////////

            //var T5 = (from i in goods1 select i.Category).Distinct();
            //foreach (var item in T5)
            //{
            //    Console.WriteLine(item);
            //}
            ///////////////////////////////////////////////////////////////////////////////////////

            //var T6 = (from i in goods1 select i.Price);
            ///////////////////////////////////////////////////////////////////////////////////////

            //var T7 = (from i in goods1 orderby i.Title select i.Title);
            //foreach (var i in T7)
            //{
            //    Console.WriteLine(i);
            //}
            ///////////////////////////////////////////////////////////////////////////////////////

            //var T8 =  goods1.Where(t => t.Price>1000&&t.Price<2000&&t.Category=="Car").Count()!=0;
            //Console.WriteLine(T8?"Yes":"No");
            ///////////////////////////////////////////////////////////////////////////////////////

            //var T9 = goods1.Where(t => t.Category == "Car" || t.Category == "Mobile").Count();
            //Console.WriteLine(T9);
            ///////////////////////////////////////////////////////////////////////////////////////

            //var T10 = from i in goods1 select "Category : " + i.Category + "Count : " + ((from j in goods1 where j.Category == i.Category select j.Id).Distinct().Count());
            //foreach (var i in T10)
            //{
            //    Console.WriteLine(i);
            //}


            /////////////////////////////////////////////////////////////////////////////////////

            /////////////////////////////////////////////////////////////////////////////////////

            int[] values1 = new int[5] { 1, 10, 5, 13, 4 };
            int[] values2 = new int[5] { 19, 1, 4, 9, 8 };

            /////////////////////////////////////////////////////////////////////////////////////
            ///////////////////////TASK_1
            //var res = values1.Concat(values2).Average();//////////////////////////////////////<<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
            //Console.WriteLine(res);


            ////////////TASK_2
            //var res2 = values1.Concat(values2).Distinct();/////////////////////////////////////////<<<<<<<<<<<<<<<<<<<<<<<<<<
            //foreach (var i in res2)
            //{
            //    Console.WriteLine(i);
            //}


            ///////////TASK_3
            //var res3 = values2.Intersect(values1).Max();/////////////////////////////////////<<<<<<<<<<<<<<<<<<<<<<<<<<<<<
            //Console.WriteLine(res3);


            /////////////TASK_4
            //var res4 = values1.Concat(values2).Where(q=>q>=5&&q<15);//////////////////////////////<<<<<<<<<<<<<<<<<<
            //foreach (var i in res4)
            //{
            //    Console.WriteLine(i);
            //}

            ////////////////TASK_5
            //var res5 = values1.Concat(values2).OrderByDescending(q=>q);
            //foreach (var i in res5)
            //{
            //    Console.WriteLine(i);
            //}
            /*
            1) Посчитать среднее значение четных элементов, которые больше 10.
            2) Выбрать только уникальные элементы из массивов values1 и values2.
            3) Найти максимальный элемент массива values2, который есть в массиве values1.
            4) Посчитать сумму элементов массивов values1 и values2, которые попадают
            в диапазон от 5 до 15.
            5) Отсортировать элементы массивов values1 и values2 по убыванию.
             */
        }
    }
}
