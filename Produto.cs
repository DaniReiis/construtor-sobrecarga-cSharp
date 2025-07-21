using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace construtores
{
    internal class Produto
    {
        private string _nome { get; set; } // Nome é privado para evitar acesso direto, mas pode ser acessado através de métodos públicos então usamos _ e o nome em usculo para indicar que é um campo privado.
        private double _preco { get; } // Preço é privado para evitar acesso direto, mas pode ser acessado através de métodos públicos então usamos _ e o nome em usculo para indicar que é um campo privado.
        private int _quantidade { get; set; } // Preço é privado para evitar acesso direto, mas pode ser acessado através de métodos públicos então usamos _ e o nome em usculo para indicar que é um campo privado.

        public Produto(string nome, double preco, int quantidade) 
        {
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }   

        public Produto(string nome, double preco) : this(nome, preco, 10) //sobrecarga de construtor com estoque sempre começando com 10 unidades
        {
        }

        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            _quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            _quantidade -= quantidade;
        }
        public override string ToString()
        {
            return _nome
            + ", $ "
            + _preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + _quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
