using System;
using System.Collections.Generic;
using System.Text;

namespace PagamentoImposto
{
    class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }
        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto = SalarioBruto + (SalarioBruto * (porcentagem / 100));
        }
        public override string ToString()
        {
            return "Funcionário: "
                + Nome
                + ", $"
                + SalarioLiquido();
        }
    }
}
