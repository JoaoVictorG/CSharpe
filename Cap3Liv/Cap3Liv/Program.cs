using System;
using static System.Console;
namespace Cap3Liv
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = "  Text   ";
            WriteLine("Nome:" + nome);
            WriteLine($"Tamanho:{nome.Length}");
            WriteLine($"Nome:{nome.Trim()}");
            WriteLine($"Tamanho:{nome.Trim().Length}");
            WriteLine($"Nome: {nome}");
            WriteLine($"Nome: {nome.ToUpper()}");
        }
    }
}
