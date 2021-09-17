using System;
using System.Globalization;

namespace ContaBanco
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta;
            Console.WriteLine("Entre com o Número da Conta:");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o nome do Titular da Conta");
            string titular = Console.ReadLine();
            Console.WriteLine("Haverá depósito Inicial?");
            char resp = char.Parse(Console.ReadLine());
            if (resp == 's' || resp == 'S')
            {
                Console.WriteLine("Entre com o valor Inicial");
                double depositoInicial = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                conta = new Conta(numero, titular, depositoInicial);
            }
            else
            {
                conta = new Conta(numero, titular);
            }
            Console.WriteLine();
            Console.WriteLine("Dados da Conta");
            Console.WriteLine(conta);
        }
    }
}
