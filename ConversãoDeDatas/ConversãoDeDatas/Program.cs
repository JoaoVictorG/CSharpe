using System;

namespace ConversãoDeDatas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Conversão de texto para Date");
            string dataTexto =
                // "2021-10-20"; // invariant
                // "20/10/2021";
                "10/20/2021"; // en-us
            DateTime dataTextoConvertida;
            if(DateTime.TryParse(dataTexto
                , System.Globalization.CultureInfo.GetCultureInfo("pt-br")
                , System.Globalization.DateTimeStyles.None
                , out dataTextoConvertida))
            {
                Console.WriteLine($"Data com conversão Aceita {dataTextoConvertida}");
            }
            else
            {
                Console.WriteLine($"Erro na conversão {dataTextoConvertida}");
            }
            string dataTextoErrada = "20/outubro/2021";
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
