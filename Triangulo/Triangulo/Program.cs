using System;
using System.Globalization;
namespace Triangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            TrianguloClass x, y;
            x = new TrianguloClass();
            y = new TrianguloClass();

            Console.WriteLine("Entre com as medidas do triângulo x:");
            x.A = double.Parse(Console.ReadLine());
            x.B = double.Parse(Console.ReadLine());
            x.C = double.Parse(Console.ReadLine());

            Console.WriteLine("Entre com as medidas do triângulo y:");
            y.A = double.Parse(Console.ReadLine());
            y.B = double.Parse(Console.ReadLine());
            y.C = double.Parse(Console.ReadLine());

            double areaX = x.Area();

            Console.WriteLine("Valor área X: " + areaX.ToString("F2",CultureInfo.InvariantCulture));

            double areaY = y.Area();
            Console.WriteLine("Valor área Y: " + areaY.ToString("F2",CultureInfo.InvariantCulture));
            if(areaX > areaY)
            {
                Console.WriteLine("Maior valor: X");
            }
            else
            {
                Console.WriteLine("Maior valor: Y");
            }
        }
    }
}
