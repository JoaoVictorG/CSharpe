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
            return (p * q) * Iof;  
        }

    }
}
