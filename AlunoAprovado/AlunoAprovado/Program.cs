using System;
using System.Globalization;

namespace AlunoAprovado
{
    class Program
    {
        static void Main(string[] args)
        {
            var al = new Aluno();
            Console.WriteLine("Qual o nome do Aluno?");
            al.Nome = Console.ReadLine();
            Console.WriteLine("Qual a nota do primeiro trimestre?");
            al.Nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual a nota do segundo trimestre?");
            al.Nota2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual a nota do terceiro trimestre?");
            al.Nota3 = double.Parse(Console.ReadLine());

            Console.WriteLine("Nota Final: " + al.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));
            if (al.Aprovacao())
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("Reprovado");
                Console.WriteLine("Faltaram: " + al.NotaRestante().ToString("F2", CultureInfo.InvariantCulture) + " pontos");
            }
        }
    }
}
