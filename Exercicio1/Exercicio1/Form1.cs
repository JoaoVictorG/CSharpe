using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true && panel1.BackColor == Color.Red)
            {
                panel1.BackColor = Color.Blue;
            }
            else if(checkBox1.Checked == true && panel1.BackColor == Color.Blue){
                panel1.BackColor = Color.Red;
            }
            else
            {
                MessageBox.Show("A caixa não está marcada, porfavor marque");
            }
        }
    }
}
