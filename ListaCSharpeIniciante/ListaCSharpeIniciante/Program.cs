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

            Console.WriteLine();
            foreach(string pessoa in nomesFuncionarios)
            {
                Console.WriteLine(pessoa);
            }
        }
    }
}
