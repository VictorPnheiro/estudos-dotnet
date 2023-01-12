using System.Drawing;
using System.Runtime.Intrinsics.X86;

namespace Curso
{
    
    internal class Retangulo
    {
        //atributos
        public double Largura;
        public double Altura;
        
        //metodos
        public double Area()
        {
            return Largura * Altura;
        }

        public double Perimetro()
        {
            return 2*(Largura + Altura);
        }

        public double Diagonal()
        {
            return Math.Sqrt(Math.Pow(Largura, 2) + Math.Pow(Altura, 2));
        }
    
    }

}
