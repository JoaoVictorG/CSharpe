using System;

namespace Welcome1
{
    class Welcome1
    {
        static void Main()
        {
            int number1;
            int number2;
            int sum;

            Console.WriteLine("Entre com o primeiro numero");
            number1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o segundo numero");
            number2 = int.Parse(Console.ReadLine());

            sum = number1 + number2;

            Console.WriteLine($"O resultado é {sum}");
        }
    }
}
