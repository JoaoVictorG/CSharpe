using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro valor:");
            float valor1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor:");
            float valor2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o terceiro valor");
            float valor3 = int.Parse(Console.ReadLine());
            float soma = valor1 + valor2 + valor3;
            double desconto = soma * 0.1;
            double resultado = soma - desconto;
            Console.WriteLine($"O valor a se pagar é {resultado}");
            
            
        }
    }
}
