//namespace Curso
//{
//    internal class Produto
//    {
//        public string? Nome;
//        public double Preco;
//        public double QuantidadeEstoque;

//        public double ValorTotalEmEstoque()
//        {
//            return Preco * QuantidadeEstoque;
//        }

//        public void AdicionarProdutos(int quantidade)
//        {
//            QuantidadeEstoque += quantidade;
//        }

//        public void RemoverProdutos(int quantidade)
//        {
//            QuantidadeEstoque -= quantidade;
//        }

//        public override string ToString()
//        {
//            return ($"{Nome}, " +
//                $"${Preco.ToString("F2", CultureInfo.InvariantCulture)}, " +
//                $"{QuantidadeEstoque} unidades, " +
//                $"Total: ${ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)}");
//        }
//    }

//    //Programa
//    Produto p = new Produto();

//    Console.WriteLine("Entre os dados do produto:");
//            Console.Write("Nome: ");
//            p.Nome = Console.ReadLine();
//            Console.Write("Preço: ");
//            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
//    Console.Write("Quantidade em estoque: ");
//            p.QuantidadeEstoque = int.Parse(Console.ReadLine());

//    Console.WriteLine();
//            Console.WriteLine($"Dados do produto: {p}");
            
//            Console.WriteLine();
//            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
//            int qte = int.Parse(Console.ReadLine());
//    p.AdicionarProdutos(qte);

//            Console.WriteLine();
//            Console.WriteLine($"Dados atualizados: {p}");

//            Console.WriteLine();
//            Console.WriteLine("Digite o número de produtos a ser removido do estoque:");
//            qte = int.Parse(Console.ReadLine());
//    p.RemoverProdutos(qte);

//            Console.WriteLine();
//            Console.WriteLine($"Dados atualizados: {p}");

//}
