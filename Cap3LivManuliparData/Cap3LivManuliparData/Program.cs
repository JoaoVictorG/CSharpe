using System;
using System.Globalization;
namespace Cap3LivManuliparData
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dtPedido = DateTime.Today;
            DateTime dtVencto = dtPedido.AddDays(35);

            DateTime dtPago = dtVencto.AddMonths(2);
            Console.WriteLine($"Pedidio feito e: {dtPedido: dd/MMM/yyyy} vence em {dtVencto: dd/MMM/yyyy}");

            Console.WriteLine($"Formatação Completa: {dtVencto.ToLongDateString()}");
            Console.WriteLine($"Formatação Completa: {dtVencto.ToLongDateString()}");

            Console.WriteLine($"Dia da semana: {dtVencto.DayOfWeek}");
            Console.WriteLine($"Dia da semana em português {dtVencto.ToString("dddd", new CultureInfo("pt-BR"))}");
            Console.WriteLine($"Numero do dia da semana: {(int)dtVencto.DayOfWeek}");

        }
    }
}
