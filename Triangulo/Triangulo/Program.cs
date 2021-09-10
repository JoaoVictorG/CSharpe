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

            x.P = (x.A + x.B + x.C) / 2;
            x.Area = Math.Sqrt(x.P * (x.P - x.A) * (x.P - x.B) * (x.P - x.C));
            Console.WriteLine("Valor área X:" + x.Area.ToString("F4", CultureInfo.InvariantCulture));

            y.P = (y.A + y.B + y.C) / 2;
            y.Area = Math.Sqrt(y.P * (y.P - y.A) * (y.P - y.B) * (y.P - y.C));
            Console.WriteLine("Valor área Y: " + y.Area.ToString("F4",CultureInfo.InvariantCulture));
            if(x.P > y.P)
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
