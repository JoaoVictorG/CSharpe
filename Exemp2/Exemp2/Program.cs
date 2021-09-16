using System;
using System.Globalization;
namespace Exemp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Produto("TV", 500.00, 10);
            p.SetNome("TV 4K");
            Console.WriteLine(p.GetNome() + " e " + p.GetPreco() + " e " + p.GetQuantidade());
        } 
    }
}
