using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Contatos
{
    class OutraClass
    {
        public static void NotMain()
        {
            MessageBox.Show("Pow!");
            for (int i = 0;i <= 8;i = i + 2)
            {
                MessageBox.Show($"Vou aparecer 4 vezes {i}");
            }
        }
    }
}
