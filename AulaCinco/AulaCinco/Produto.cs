
using System.Globalization;

namespace AulaCinco
{
    public class Produto
    {
        public string? Nome;
        public double Preco;
        public int Quantidade;

        //construtor
        public Produto(string? nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        //sobrecarga - outro construtor
        //public Produto(string? nome, double preco)
        //{
        //    Nome = nome;
        //    Preco = preco;
        //    //Por padrao, int já vem com zero
        //    //Quantidade = 0;
        //}

        //sobrecarga para que funcione sem construtor construtor
        public Produto() { }

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return Nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
