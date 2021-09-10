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

            Console.WriteLine("Digite a Quantidade de produtos adicionados");
            int qte = int.Parse(Console.ReadLine());

            produto.AdicionarProduto(qte);

            Console.WriteLine("Dados Atualizados " + produto);

            Console.WriteLine("Digite a Quantidade de produtos removidos");
            qte = int.Parse(Console.ReadLine());
            produto.RemoverProduto(qte);

            Console.WriteLine("Dados Atualizados " + produto);
        }
    }
}
