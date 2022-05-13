using System;
using System.Globalization;
class main
{
    static void Main(string[] args)
    {
        Console.WriteLine("Escolhar uma opção:");
        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Multiplicação");
        Console.WriteLine("4 - Divisão");

        int operacao = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o primeiro valor: ");
        double valor1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo valor: ");
        double valor2 = double.Parse(Console.ReadLine());

        double Soma(double valor1, double valor2)
        {
            return valor1 + valor2;
        }
    }
}
