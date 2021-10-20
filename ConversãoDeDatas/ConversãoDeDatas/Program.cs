using System;

namespace ConversãoDeDatas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Conversão de texto para Date");
            string dataTexto = "20/10/2021";
            DateTime dataTextoConvertida;
            if(DateTime.TryParse(dataTexto, out dataTextoConvertida))
            {
                Console.WriteLine("Data com conversão Aceita");
            }
            else
            {
                Console.WriteLine("Erro na conversão");
            }
            string dataTextoErrada = "20/mês 10/2021";
            DateTime dataTextoErradaConvertida;
            if(DateTime.TryParse(dataTextoErrada, out dataTextoErradaConvertida))
            {
                Console.WriteLine("Data com conversão Aceita");
            }
            else
            {
                Console.WriteLine("Erro na conversão");
            }
        }
    }
}
