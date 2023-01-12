//using System.Drawing;
//using System.Runtime.Intrinsics.X86;

//namespace Curso
//{
//    //Exercicio 1
//    // Fazer um programa para ler os valores da largura e altura de um retângulo. Em
//    //seguida, mostrar na tela o valor de sua área, perímetro e diagonal.Usar uma classe
//    //como mostrado no projeto ao lado.


//    internal class Retangulo
//    {
//        //atributos
//        public double Largura;
//        public double Altura;
        
//        //metodos
//        public double Area()
//        {
//            return Largura * Altura;
//        }

//        public double Perimetro()
//        {
//            return 2*(Largura + Altura);
//        }

//        public double Diagonal()
//        {
//            return Math.Sqrt(Math.Pow(Largura, 2) + Math.Pow(Altura, 2));
//        }
    
//    }

//    //Programa
//    Retangulo retangulo = new Retangulo();
//    Console.WriteLine("Entre a largura e altura do retângulo:");
//            retangulo.Largura = double.Parse(Console.ReadLine());
//    retangulo.Altura= double.Parse(Console.ReadLine());
//    Console.WriteLine($"Area = {retangulo.Area().ToString("F2", CultureInfo.InvariantCulture)}");
//            Console.WriteLine($"Perímetro = {retangulo.Perimetro().ToString("F2", CultureInfo.InvariantCulture)}");
//            Console.WriteLine($"Diagonal = {retangulo.Diagonal().ToString("F2", CultureInfo.InvariantCulture)}");


//}
