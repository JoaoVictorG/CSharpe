﻿using System;
using System.Globalization;

namespace Exemp2
{
    class Produto
    {
        private string _nome;
        private double _preco;
        private int _quantidade;

        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }
        public string GetNome()
        {
            return _nome;
        }
        public void SetNome(string nome)
        {
            if(nome != null && nome.Length > 1)
            {
                _nome = nome;
            }
        }
        public double GetPreco()
        {
            return _preco;
        }
        public int GetQuantidade()
        {
            return _quantidade;
        }
        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }
        public void AdicionarProduto(int quantidade)
        {
            _quantidade = _quantidade + quantidade;
        }
        public void RemoverProduto(int quantidade)
        {
            _quantidade = _quantidade - quantidade;
        }
        public override string ToString()
        {
            return _nome 
                + ", $ " 
                + _preco.ToString("F2", CultureInfo.InvariantCulture) 
                + ", " 
                + _quantidade 
                + " unidades., Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
