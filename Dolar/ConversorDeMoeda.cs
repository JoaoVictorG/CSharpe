using System;
using System.Collections.Generic;
using System.Text;

namespace Dolar
{
    class ConversorDeMoeda
    {
        public static double Iof = 0.06;

        public static double Calculo(double p,double q)
        {
            Console.WriteLine(Iof);
            double valor = p * q;
            double imposto = valor * Iof;
            return (imposto + valor)/100;
        }

    }
}
