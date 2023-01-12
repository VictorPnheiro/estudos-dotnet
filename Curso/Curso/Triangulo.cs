namespace Curso
{
    internal class Triangulo
    {
        //atributos
        public double A;
        public double B;
        public double C;


        //métodos
        public double Area()
        {
            double p = (A + B + C) / 2.0;
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
}
