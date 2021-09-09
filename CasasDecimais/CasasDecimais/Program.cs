using System;
using System.Globalization;
namespace CasasDecimais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            double valor = 1243.987;
            Console.WriteLine(valor.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
