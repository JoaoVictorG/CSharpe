using System;
using System.Collections.Generic;
using System.Text;

namespace CalculoCirculo
{
    class Calculo
    {
        public double Raio;
        public double Pi = 3.14;
        public double Circunferencia()
        {
            return 2 * Pi * Raio;
        }
        public double Volume()
        {
            return (4 * Pi * (Raio * Raio * Raio)) / 3;
        }
    }
}
