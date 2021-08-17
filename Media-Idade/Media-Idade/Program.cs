using System;

namespace Media_Idade
{
    class Program
    {
        static void Main(string[] args)
        {  
             /*    =====    Média das idades    =====    */
            Console.WriteLine("Qual a idade da primera pessoa?");
            int idade1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Qual a idade da segunda pessoa?");
            int idade2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Qual a idade da terceira pessoa?");
            int idade3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Qual a idade da quarta pessoa?");
            int idade4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Qual a idade da quinta pessoa?");
            int idade5 = Convert.ToInt32(Console.ReadLine());
            int resultado = (idade1 + idade2 + idade3 + idade4 + idade5) / 5;
            Console.WriteLine($"A idade média é {resultado}");
        }
    }
}
