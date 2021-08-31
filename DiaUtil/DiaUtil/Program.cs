using System;

namespace DiaUtil
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o dia:");
            int dia = int.Parse(Console.ReadLine());
            if(dia > 1 && dia <= 5)
            {
                Console.WriteLine("Dia útil");
            }
            if(dia == 6 || dia == 7)
            {
                Console.WriteLine("Fim de semana");
            }
            else
            {
                Console.WriteLine("Inválido");
            }

        }
    }
}
