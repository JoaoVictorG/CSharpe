﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contatos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lista de Contatos 1.0. escrito por: João Victor", "Sobre");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Teste");
        }
    }
}
