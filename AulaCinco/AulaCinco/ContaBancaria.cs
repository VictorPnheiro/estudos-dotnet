

using System.Globalization;

namespace AulaCinco
{
    class ContaBancaria
    {

        public int NumeroConta { get; private set; }
        public string? Titular { get; set; }
        public double Saldo { get; private set; }


        public ContaBancaria(int numeroConta, string? titular)
        {
            NumeroConta = numeroConta;
            Titular = titular;
        }

        public ContaBancaria(int numeroConta, string? titular, double saldo) : this(numeroConta, titular)
        {
            Saldo = saldo;
        }

        public void Deposito(double quantia)
        {
            Saldo += quantia;
        }

        public void Saque(double quantia)
        {
            Saldo -= quantia + 5.0;
        }

        public override string ToString()
        {
            return ($"Conta: {NumeroConta}, " +
                $"Titular: {Titular}, " +
                $"Saldo: R${Saldo.ToString("F2", CultureInfo.InvariantCulture)}");
        }

    }

}
