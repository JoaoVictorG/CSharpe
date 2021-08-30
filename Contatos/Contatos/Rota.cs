using System;
using System.Collections.Generic;
using System.Text;
using Contatos.Destino;

namespace Contatos
{
    public class Rota : Caminho
    {

    }
}

namespace Contatos.Destino
{
    public class Caminho
    {
        public int X { get; set; }
        public int Y { get; set; }

        public int CalcularDistancia(int x, int y)
        {
            return 10;
        }
    }
}
