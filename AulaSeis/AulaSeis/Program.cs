using System;
using System.Globalization;

namespace AulaSeis
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            list.Add("Victor");
            list.Add("Miguel");
            list.Add("Kelv");
            list.Add("Marlon");
            list.Add("Friba");
            list.Insert(2, "Akio");

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("list.Count: " + list.Count);

            string? s1 = list.Find(x => x[0] == 'M');
            Console.WriteLine("First 'M': " + s1);

            string? s2 = list.FindLast(x => x[0] == 'M');
            Console.WriteLine("Last 'M': " + s2);

            int pos1 = list.FindIndex(x => x[0] == 'M');
            Console.WriteLine("Primeira posiçao 'M': " + pos1);

            int pos2 = list.FindLastIndex(x => x[0] == 'M');
            Console.WriteLine("Primeira posiçao 'M': " + pos2);

            Console.WriteLine("====================");
            List<string> list2 = list.FindAll(x => x.Length == 6);
            foreach (var item in list2)
            {
                Console.WriteLine(item);
            }

            list.Remove("Akio");
            Console.WriteLine("====================");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            list.RemoveAll(x => x[0] == 'M');
            Console.WriteLine("====================");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            list.RemoveAt(1);
            Console.WriteLine("====================");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            list.RemoveRange(0, 2);
            Console.WriteLine("====================");
            Console.WriteLine("Oi!");
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}