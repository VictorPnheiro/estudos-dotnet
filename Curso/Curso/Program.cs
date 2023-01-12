using System.ComponentModel;
using System.Globalization;
using System.Runtime.ConstrainedExecution;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            //EXERCÍCIO 02:
            //Fazer um programa para ler os dados de um funcionário(nome,
            //    salário bruto e imposto). Em seguida, mostrar os dados do
            //    funcionário(nome e salário líquido).Em seguida, aumentar o salário
            //    do funcionário com base em uma porcentagem dada(somente o
            //    salário bruto é afetado pela porcentagem) e mostrar
            //novamente os dados do funcionário.Use a classe projetada abaixo.

            Funcionario funcionario = new Funcionario();

            Console.WriteLine("Digite os dados do funcionário:");
            Console.Write("Nome: ");
            funcionario.Nome = Console.ReadLine();
            Console.Write("Salário bruto: ");
            funcionario.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: "); 
            funcionario.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();

            Console.WriteLine($"Funcionário: {funcionario}");
            Console.WriteLine();

            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            funcionario.AumentarSalario(porcentagem);
            Console.WriteLine();

            Console.WriteLine($"Dados atualizados: {funcionario}");
        }

    }
}
