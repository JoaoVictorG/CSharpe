using System;
using System.Collections.Generic;
using System.Text;

namespace ContaBanco
{
    class Conta
    {
        public int Numero { get; private set;}
        public string Titular { get; set;}
        public double Saldo { get; private set;}

        public Conta(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }
        public Conta(int numero, string titular, double saldo) : this(numero, titular)
        {
            Saldo = saldo;
        }
    }
}
