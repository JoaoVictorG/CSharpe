using System;

namespace Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o número de pessoas");
            int num = int.Parse(Console.ReadLine());
            double[] altura;
            altura = new double[num];
            for (int i = 0; i <= num; i++)
            {
                Console.WriteLine("Digite a altura de uma pessoa: ");
                altura[i] = double.Parse(Console.ReadLine());
            }
            foreach (double alturas in altura)
            {
                Console.WriteLine(altura);
            }
        }
    }
}
