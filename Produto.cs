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
        public string Nome { get; set; } // Nome é privado para evitar acesso direto, mas pode ser acessado através de métodos públicos então usamos _ e o nome em usculo para indicar que é um campo privado.
        public double Preco { get; private set; } // Preço é privado para evitar acesso direto, mas pode ser acessado através de métodos públicos então usamos _ e o nome em usculo para indicar que é um campo privado.
        public int Quantidade { get; set; } // Preço é privado para evitar acesso direto, mas pode ser acessado através de métodos públicos então usamos _ e o nome em usculo para indicar que é um campo privado.

        public Produto(string nome, double preco, int quantidade) 
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }   

        public Produto(string nome, double preco) : this(nome, preco, 10) //sobrecarga de construtor com estoque sempre começando com 10 unidades
        {
        }

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return Nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
