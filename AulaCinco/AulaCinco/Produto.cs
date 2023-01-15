
using System.Globalization;

namespace AulaCinco
{
    public class Produto
    {
        //*Ordem sugerida para implementação de membros*

        //* Atributos privados *
        //auto propertie {get; set;}
        private string? _nome;

        //* Propriedades autoimplementadas *
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        //* Construtores *
        //construtor padrão
        public Produto() { }

        //construtor próprio
        public Produto(string? nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        //* Propriedades customizadas *
        //propertie
        public string Nome
        {
            get { return _nome; }
            set
            {
                //por conta da validação manual, nao utilizaremos Auto Propertie
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                };
            }
        }


        //* Outros métodos da classe *
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
            return _nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
