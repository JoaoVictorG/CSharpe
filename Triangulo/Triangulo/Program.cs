using System;
using System.Globalization;
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

            Console.WriteLine("Entre com as medidas do triângulo y:");
            double aY = double.Parse(Console.ReadLine());
            double bY = double.Parse(Console.ReadLine());
            double cY = double.Parse(Console.ReadLine());

            double pX = (aX + bX + cX) / 2;
            double areaX = Math.Sqrt(pX * (pX - aX) * (pX - bX) * (pX - cX));
            Console.WriteLine(areaX.ToString("F4", CultureInfo.InvariantCulture));

            double pY = (aY + bY + cY) / 2;
            double areaY = Math.Sqrt(pY * (pY - aY) * (pY - bY) * (pY - cY));
            Console.WriteLine(areaY.ToString("F4",CultureInfo.InvariantCulture));
        }
    }
}
