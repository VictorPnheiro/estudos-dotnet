using System;
using System.Globalization;

namespace AulaSeis
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n, n];
            for (int linha = 0; linha < n; linha++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for (int coluna = 0; coluna < n; coluna++)
                {
                    mat[linha, coluna] = int.Parse(values[coluna]);
                }
            }

            Console.WriteLine("Main diagonal:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(mat[i, i] + " ");
            }
            Console.WriteLine();


            int count = 0;
            for (int linha = 0; linha < n; linha++)
            {
                for (int coluna = 0; coluna < n; coluna++)
                {
                    if (mat[linha, coluna] < 0)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine("Negative numbers: " + count);
        }
    }
}