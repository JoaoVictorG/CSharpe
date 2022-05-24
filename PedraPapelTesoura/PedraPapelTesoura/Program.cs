using System;

namespace PedraPapelTesoura
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Escolha sua jogada:");
            Console.WriteLine("0 - Pedra");
            Console.WriteLine("1 - Papel");
            Console.WriteLine("2 - Tesoura");
            
            //Console.WriteLine("Você"jogadaHumano);
            int i = 1;
            while (i != 2)
            {
                int jogadaHumano = int.Parse(Console.ReadLine());
                Random rnd = new Random();

                int jogadaComputador = rnd.Next(0, 3);
                
                Console.WriteLine("Você escolheu: ");
                Console.WriteLine(jogadaHumano);
                Console.WriteLine("Seu adiversário escolheu: ");
                Console.WriteLine(jogadaComputador);

                //Console.WriteLine(numeroAleatorio);
                if (jogadaHumano - jogadaComputador == 0)
                {
                    Console.WriteLine("Você empatou");
                }
                else if (jogadaHumano - jogadaComputador == (-2) || jogadaHumano - jogadaComputador == 1)
                {
                    Console.WriteLine("Você ganhou");
                    i++;
                }
                else
                {
                    Console.WriteLine("Você perdeu");
                }


            }    
            //string textoHumano;
            //if (jogadaHumano == 0)
            //{
            //    textoHumano = "Pedra";
            //}
            //else if(jogadaHumano == 1)
            //{
            //    textoHumano = "Papel";
            //}
            //else if(jogadaHumano == 2)
            //{
            //    textoHumano = "Tesoura";
            //}

            //Console.WriteLine($"Você escolheu: {textoHumano}");
        }
    }
}
