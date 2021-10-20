using System;

namespace Cap3LivNow
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime hoje = DateTime.Today;
            Console.WriteLine("TODAY - retorno a data atual");
            Console.WriteLine($"TODAY: {hoje: dd/MM/yyyy}");

            DateTime DataHora = DateTime.Now;
            Console.WriteLine("Now - retorna data e hora atual");
            Console.WriteLine($"Data e Hora: {DataHora: dd/MM/yyyy hh:mm:ss}");
        }
    }
}
