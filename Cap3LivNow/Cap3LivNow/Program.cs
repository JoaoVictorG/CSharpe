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
        }
    }
}
