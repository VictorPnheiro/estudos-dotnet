using System.Globalization;

namespace Curso
{
    internal class Funcionario
    {
        //atributos
        public string? Nome;
        public double SalarioBruto;
        public double Imposto;

        //metodos
        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcentagem) 
        {
            SalarioBruto = SalarioBruto + (SalarioBruto * porcentagem / 100.0);
        }

        public override string ToString()
        {
            return ($"{Nome}, ${SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
