using System;
using System.Collections.Generic;

namespace ListPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            List<DateTime> holid = new List<DateTime>
            {
            new DateTime(2021,1,1),
            new DateTime(2021,2,12),
            new DateTime(2021,3,13),
            new DateTime(2021,4,14),
            new DateTime(2021,5,15),
            new DateTime(2021,6,16),
            new DateTime(2021,7,17),
            };

            Console.WriteLine("Before adding element in list : ");
            foreach (var hoiday in holid)
            {

                Console.WriteLine(hoiday);
            }

            //Adding an element into list
            Console.WriteLine("\nAfter adding element in list : ");
            holid.Add(new DateTime(2021, 4, 23));

            foreach (var hoiday in holid)
            {

                Console.WriteLine(hoiday);
            }

        }
    }
}
