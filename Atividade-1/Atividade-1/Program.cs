using System;

namespace Atividade_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite seu nome:");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite sua data de nascimento:");
            string dataNascimento = Console.ReadLine();
            Console.WriteLine("Digite sua altura");
            double altura = double.Parse(Console.ReadLine());

            var dado = new Pessoa(nome, dataNascimento, altura);

            Console.WriteLine(dado);

        }
    }
}
