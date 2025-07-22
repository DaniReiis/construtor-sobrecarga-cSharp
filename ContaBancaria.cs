using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace construtores
{
    internal class ContaBancaria
    {
        public double Saldo { get; private set; }
        public int numeroConta { get; private set; }
        public string Nome { get; set; }

        public ContaBancaria(string nome, int numeroConta)
        {
            Nome = nome;
            this.numeroConta = numeroConta;
        }

        public ContaBancaria(string nome, int numeroConta, double saldoIncial) : this(nome, numeroConta)
        {
            AdicionarSaldo(saldoIncial);
        }

        public void AdicionarSaldo(double valor)
        {
            Saldo += valor;
        }

        public void RemoverSaldo(double valor)
        {
            Saldo -= valor + 5.00; // Deduz uma taxa de 5.00 ao remover saldo
        }


        public override string ToString()
        {
            return $"Conta {numeroConta}, Titular: {Nome}, Saldo: R$ {Saldo:F2}";
        }

    }
}
