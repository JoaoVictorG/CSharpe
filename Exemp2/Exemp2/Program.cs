using System;
using System.Globalization;
namespace Exemp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados do Produto:");
            Console.WriteLine("Nome:");
            string nome = Console.ReadLine();
            Console.WriteLine("Preço");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            var produto = new Produto(nome, preco);

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
