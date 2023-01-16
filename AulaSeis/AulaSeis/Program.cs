using System.Globalization;

namespace AulaSeis
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Produto[] produtos = new Produto[n];

            for (int i = 0; i < n; i++)
            {
                string nome = Console.ReadLine();
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                produtos[i] = new Produto { Nome = nome, Preco = preco };
            }

            double soma = 0;

            for (int i = 0; i < n; i++)
            {
                soma += produtos[i].Preco;
            }

            double media = soma / n;

            Console.WriteLine($"Preço médio: {media.ToString("F2", CultureInfo.InvariantCulture)}");

        }
    }
}