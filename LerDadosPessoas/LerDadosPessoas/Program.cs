using System;

namespace LerDadosPessoas
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoas p1, p2;
            p1 = new Pessoas();
            p2 = new Pessoas();

            Console.WriteLine("Digite o nome da primeira Pessoa");
            p1.Nome = Console.ReadLine();
            Console.WriteLine("Agora digite sua idade");
            p1.Idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual seu sexo?");
            p1.Sexo = Console.ReadLine();

            Console.WriteLine("Digite o nome da segunda Pessoa");
            p2.Nome = Console.ReadLine();
            Console.WriteLine("Agora digite sua idade");
            p2.Idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual seu sexo?");
            p2.Sexo = Console.ReadLine();

            if (p1.Idade > p2.Idade)
            {
                Console.WriteLine(p1.Nome + " é a pessoa mais velha");
            }
            else if(p2.Idade > p1.Idade){
                Console.WriteLine(p2.Nome + " é a pessoa mais velha");
            }
            else
            {
                Console.WriteLine(p1.Nome + " e " + p2.Nome + " possuem a mesma idade");
            }
        }
    }
}
