using System;

namespace TabelaPrecos
{
    class Program
    {
        static void Main(string[] args)
        {
            /*    =====    Tabela    =====    */
            Console.WriteLine("Tabela de Preços");
            Console.WriteLine("Código    Especificação    Preço");
            Console.WriteLine("1         Cachorro Quente  R$4.00");
            Console.WriteLine("2         X-Salada         R$4.50");
            Console.WriteLine("3         X-Bacon          R$5.00");
            Console.WriteLine("4         Torrada Simples  R$2.00");
            Console.WriteLine("5         Refrigerante     R$1.50");
            /*    =====    Pedido    =====    */
            Console.WriteLine("Qual item você deseja?");
            int cod1 = 1;
            int cod2 = 2;
            int cod3 = 3;
            int cod4 = 4;
            int cod5 = 5;
            double valor_cod1 = 4.00;
            double valor_cod2 = 4.50;
            double valor_cod3 = 5.00;
            double valor_cod4 = 2.00;
            double valor_cod5 = 1.50;
            int pedido = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Quantos itens?");
            int quantidade = Convert.ToInt32(Console.ReadLine());
            while(pedido <= 5)
            {
                if (pedido == cod1)
                {
                    double valor_total = valor_cod1 * quantidade;
                    Console.WriteLine($"O valor total foi de R${valor_total}");
                    break;
                }
                if (pedido == cod2)
                {
                    double valor_total = valor_cod2 * quantidade;
                    Console.WriteLine($"O valor total foi de R${valor_total}");
                    break;
                }
                if (pedido == cod3)
                {
                    double valor_total = valor_cod3 * quantidade;
                    Console.WriteLine($"O valor total foi de R${valor_total}");
                    break;
                }
                if (pedido == cod4)
                {
                    double valor_total = valor_cod4 * quantidade;
                    Console.WriteLine($"O valor total foi de R${valor_total}");
                    break;
                }
                if (pedido == cod5)
                {
                    double valor_total = valor_cod5 * quantidade;
                    Console.WriteLine($"O valor total foi de R${valor_total}");
                    break;
                }
            }
        }
    }
}
