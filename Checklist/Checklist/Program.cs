using System;
using System.Globalization;
namespace Checklist
{
    class Program
    {
        static void Main(string[] args)
        {
            //int num1 = int.Parse(Console.ReadLine());
            //char char1 = char.Parse(Console.ReadLine());
            //double doub1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Digite");
            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);

            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2"));
            //Console.WriteLine(doub1.ToString("F2", CultureInfo.InvariantCulture));
            
        }
    }
}
