using System;

namespace Calc_Salario
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Objetivo: Fazer um algoritmo que calcule e exiba o salário reajustado de dez funcionários de acordo com a seguinte regra: Salário até 300, reajuste de 50%; Salários maiores que 300, reajuste de 30%");
            float funcionario = 1;
            while (funcionario < 11)
            {
                Console.WriteLine($"Digite o valor do sálário do funcionário {funcionario}");
                double salario_bruto = Convert.ToInt32(Console.ReadLine());
                if(salario_bruto > 0)
                {
                    if (salario_bruto <= 300)
                    {
                        double salario_final = salario_bruto * 1.50;
                        Console.WriteLine($"O salário do funcionario {funcionario} é {salario_final}");
                        funcionario++;
                    }
                    else
                    {
                        double salario_final = salario_bruto * 1.30;
                        Console.WriteLine($"O salário do funcionario {funcionario} é {salario_final}");
                        funcionario++;
                    }
                }
                else
                {
                    Console.WriteLine("Não é permitido salário negativo");
                }
            }
            Console.WriteLine("Fim");

        }
    }
}
