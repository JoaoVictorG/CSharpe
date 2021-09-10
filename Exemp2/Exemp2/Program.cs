using System;
using System.Globalization;
namespace Exemp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var  produto = new Produto();

            Console.WriteLine("Entre com os dados do Produto:");
            Console.WriteLine("Nome:");
            produto.Nome = Console.ReadLine();
            Console.WriteLine("Preço");
            produto.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Quantidade");
            produto.Quantidade = int.Parse(Console.ReadLine());

            var valorTotal = produto.ValorTotalEmEstoque();

            Console.WriteLine("Dados do Produto: " + produto);
        }
    }
}
