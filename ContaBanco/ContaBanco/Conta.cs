using System;
using System.Globalization;

namespace Course
{
    class ContaBancaria
    {
        private bool ContaBloqueada { get; set; } = true;

        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public ContaBancaria(int numero, string titular)
        {
            this.Numero = numero;
            Titular = titular;
        }

        public ContaBancaria(int numero, string titular, double saldo) : this(numero, titular)
        {
            Saldo = saldo;   
        }

        public void Deposito(double quantia)
        {
            if (ContaBloqueada == false)
            {
                Saldo += quantia;
            }
        }

        public void Saque(double quantia)
        {
            if(quantia > 0)
            {
                Saldo -= quantia + 5.0;
            }
            //else
            //{
            //    Saldo = Saldo;
            //}
        }

        public override string ToString()
        {
            return "Conta "
                + Numero
                + ", Titular: "
                + Titular
                + ", Saldo: $ "
                + Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}