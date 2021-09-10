using System;

namespace LerSalario
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionarios f1,f2;
            f1 = new Funcionarios();
            f2 = new Funcionarios();
            int count = 0;

            Console.WriteLine("Digite o nome do primeiro funcionário:");
            f1.Nome = Console.ReadLine();
            Console.WriteLine("Agora digite o salário dele:");
            f1.Salario = double.Parse(Console.ReadLine());
            count++;

            Console.WriteLine("Digite o nome do segundo funcionário:");
            f2.Nome = Console.ReadLine();
            Console.WriteLine("Agora digite o salário dele:");
            f2.Salario = double.Parse(Console.ReadLine());
            count++;

            double media = (f1.Salario + f2.Salario) / count;

            Console.WriteLine("A média salaria é " + media);
        }
    }
}
