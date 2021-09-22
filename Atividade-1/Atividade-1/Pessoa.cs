using System;
using System.Collections.Generic;
using System.Text;

namespace Atividade_1
{
    class Pessoa
    {
        public string Nome { get; private set; }
        public string DataNascimento { get; private set; }
        public double Altura { get; private set; }

        public Pessoa(string nome,string dataNascimento,double altura)
        {
            Nome = nome;
            DataNascimento = dataNascimento;
            Altura = altura;
        }
        public override string ToString()
        {
            return Nome +
                " " +
                DataNascimento +
                " " +
                Altura + " cm";
        }

    }
}
