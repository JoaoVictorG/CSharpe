﻿using System;
using System.Collections.Generic;
using System.Text;

namespace PagamentoImposto
{
    class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public override string ToString()
        {
            return "Funcionário: "
                + Nome
                + ", "
                + SalarioBruto;
        }
    }
}
