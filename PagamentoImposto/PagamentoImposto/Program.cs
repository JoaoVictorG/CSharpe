using System;

namespace PagamentoImposto
{
    class Program
    {
        static void Main(string[] args)
        {
            var func = new Funcionario();
            Console.WriteLine("Digite o nome do Funcionário");
            func.Nome = Console.ReadLine();
            Console.WriteLine("Digite o Salário Bruto");
            func.SalarioBruto = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do Imposto");
            func.Imposto = double.Parse(Console.ReadLine());


        }
    }
}
