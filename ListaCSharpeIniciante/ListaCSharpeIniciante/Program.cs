using System;
using System.Collections.Generic;
namespace ListaCSharpeIniciante
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nomesFuncionarios = new List<string>();
            nomesFuncionarios.Add("Maria");
            nomesFuncionarios.Add("João");
            nomesFuncionarios.Add("André");
            nomesFuncionarios.Add("Flávia");

            Console.WriteLine("Primeira Lista");
            foreach(string pessoa in nomesFuncionarios)
            {
                Console.WriteLine(pessoa);
            }
            nomesFuncionarios.RemoveAt(0);
            Console.WriteLine("");
            Console.WriteLine("Segunda Lista");
            foreach (string pessoa in nomesFuncionarios)
            {
                Console.WriteLine(pessoa);
            }

        }
    }
}
