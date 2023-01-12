using System.ComponentModel;
using System.Globalization;
using System.Runtime.ConstrainedExecution;

namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercio 1
            // Fazer um programa para ler os valores da largura e altura de um retângulo. Em
            //seguida, mostrar na tela o valor de sua área, perímetro e diagonal.Usar uma classe
            //como mostrado no projeto ao lado.
            Retangulo retangulo = new Retangulo();
            Console.WriteLine("Entre a largura e altura do retângulo:");
            retangulo.Largura = double.Parse(Console.ReadLine());
            retangulo.Altura= double.Parse(Console.ReadLine());
            Console.WriteLine($"Area = {retangulo.Area().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Perímetro = {retangulo.Perimetro().ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Diagonal = {retangulo.Diagonal().ToString("F2", CultureInfo.InvariantCulture)}");

        }

    }
}
