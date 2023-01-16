using System.Globalization;

namespace AulaSeis
{
    class Program
    {
        static void Main(string[] args)
        {
            int s1 = Soma.Sum(2, 3);
            int s2 = Soma.Sum(3, 4);

            Console.WriteLine(s1);
            Console.WriteLine(s2);

        }
    }
}