using System;

namespace Split
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o nome de três cores");
            string cor = Console.ReadLine();
            string[] vet = cor.Split(' ');
            string a = vet[0];
            string b = vet[1];
            string c = vet[2];
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

        }
    }
}
