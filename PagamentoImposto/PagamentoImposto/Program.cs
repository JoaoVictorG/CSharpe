using System;
using System.Globalization;
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

            Console.WriteLine(func);

            Console.WriteLine("Digite a porcentagem para aumetar o salário: ");
            double porcentagem = double.Parse(Console.ReadLine());
            func.AumentarSalario(porcentagem);

            Console.WriteLine(func);
        }
    }
}
