using System;

namespace FormacaoFrases
{
    class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double media = 53.234567;

            Console.WriteLine("Produtos:");
            Console.WriteLine(produto1 + ", cujo preço é $" + preco1.ToString("F2"));
            Console.WriteLine(produto2 + ", cujo preço é $" + preco2.ToString("F2"));

        }
    }
}
