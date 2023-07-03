﻿using System.Globalization;

namespace _29_encapsulamento
{
    class Produto
    {
        private string _nome;
        private double _preco;
        private int _quantidade;

        public Produto()
        {
        }

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
            if (nome != null && nome.Length > 1)
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
            double quantity = _preco * _quantidade;

            return quantity;
        }

        public void AdicionarProdutos(int quantity)
        {
            _quantidade += quantity;
        }

        public void RemoverProdutos(int quantity)
        {
            _quantidade -= quantity;
        }

        public override string ToString()
        {
            return $"{_nome}, R${_preco.ToString("f2", CultureInfo.InvariantCulture)}, {_quantidade} unidades. Total: R${ValorTotalEmEstoque().ToString("f2", CultureInfo.InvariantCulture)}";
        }
    }
}