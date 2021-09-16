using System;
using System.Globalization;

namespace Dolar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual é a cotação do dolar?");
            double precoDolar = double.Parse(Console.ReadLine());
            Console.WriteLine("Quantos doláres você quer comprar?");
            double quantDolar = int.Parse(Console.ReadLine());

            double result = ConversorDeMoeda.Calculo(precoDolar, quantDolar);
            Console.WriteLine("Valor a ser pago em reais: " + result.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
