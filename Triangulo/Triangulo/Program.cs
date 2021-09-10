using System;

namespace Triangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com as medidas do triângulo x:");
            double aX = double.Parse(Console.ReadLine());
            double bX = double.Parse(Console.ReadLine());
            double cX = double.Parse(Console.ReadLine());

            double pX = (aX + bX + cX) / 2;
            double areaX = Math.Sqrt(pX * (pX - aX) * (pX - bX) * (pX - cX));

            Console.WriteLine(areaX.ToString("F4"));
        }
    }
}
