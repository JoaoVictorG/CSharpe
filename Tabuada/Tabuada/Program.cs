using System;

namespace Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            /*    =====    Tabuada    =====    */
            Console.WriteLine("TABUADA");
            Console.WriteLine("Digite um número");
            int multiplicando = Convert.ToInt32(Console.ReadLine());
            int multiplicador = 0;
            while (multiplicador != 11)
            {
                int resultado = multiplicando * multiplicador;
                Console.WriteLine($"{multiplicando} x {multiplicador} = {resultado} ");
                multiplicador++;
            }
        }
    }
}
