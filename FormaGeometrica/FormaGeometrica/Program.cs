using System;
using System.Globalization;
namespace FormaGeometrica
{
    class Program
    {
        static void Main(string[] args)
        {
            var principal = new Retangulo();

            Console.WriteLine("Entre com a largura do retângulo");
            principal.Largura = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre com a altura do retângulo");
            principal.Altura = double.Parse(Console.ReadLine());

            Console.WriteLine("Área: " + principal.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Perímetro: " + principal.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal: " + principal.Diagonal().ToString("F2",CultureInfo.InvariantCulture));
        }
    }
}
