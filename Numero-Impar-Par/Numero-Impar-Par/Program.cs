using System;

namespace Numero_Impar_Par
{
    class Program
    {
        static void Main(string[] args)
        {
            /* =====    Número Impar ou Par    =====    */
            Console.WriteLine("Digite um número");
            int numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite mais um número");
            int numero2 = Convert.ToInt32(Console.ReadLine());
            if((numero1 % 2 == 0))
            {
                Console.WriteLine("O primeiro número é par");
            }
            else
            {
                Console.WriteLine("O primeiro número é impar");
            };
            if((numero2 % 2 == 0))
            {
                Console.WriteLine("O segundo número é par");
            }
            else
            {
                Console.WriteLine("O segundo número é impar");
            }
        }
    }
}
