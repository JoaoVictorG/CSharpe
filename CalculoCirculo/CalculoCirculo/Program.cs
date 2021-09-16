using System;
using System.Globalization;

namespace CalculoCirculo
{
    class Program
    {
        static void Main(string[] args)
        {
            var calc = new Calculo();
            Console.WriteLine("Digite o valor do Raio");
            calc.Raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Circuferência: " + calc.Circunferencia().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + calc.Volume().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valor de pi: " + calc.Pi.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
