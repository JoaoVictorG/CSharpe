using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Falante
{
    class Falante
    {
        public static int BlahBlahBlah(string frase, int vezes)
        {
            string Frasefinal = "";
            for (int countador = 1; countador <= vezes; countador++)
            {
                Frasefinal = Frasefinal + frase + "\n";
            }
            MessageBox.Show(Frasefinal);
            return Frasefinal.Length;
        }
    }
}
