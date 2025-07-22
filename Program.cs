using construtores;
using System;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o número da conta:");
            int numeroConta = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o nome do titular:");
            string nome = Console.ReadLine();

            Console.WriteLine("Haverá deposito inicial (s/n)?");
            string depositoInicial = (Console.ReadLine());

            ContaBancaria conta;

            while (depositoInicial != "s" && depositoInicial != "n" && depositoInicial != "S" && depositoInicial != "N")
            {
                Console.WriteLine("Resposta inválida. Digite 's' para sim ou 'n' para não.");
                depositoInicial = Console.ReadLine();
            }

            if (depositoInicial == "s" || depositoInicial == "S")
            {
                Console.WriteLine("Entre o valor de depósito incial");
                double valorDepositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                conta = new ContaBancaria(nome, numeroConta, valorDepositoInicial); // Usa o construtor com saldo informado
            } else
            {
                conta = new ContaBancaria(nome, numeroConta); // Usa o construtor que coloca saldo zero automaticamente
            }

            Console.WriteLine("Dados da conta: " + conta);

            Console.WriteLine("Entre um valor para depósito:");
            double valorDeposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.AdicionarSaldo(valorDeposito);

            Console.WriteLine("Dados da conta atualizados: " + conta);

            Console.WriteLine("Entre um valor para saque:");
            double valorSaque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            conta.RemoverSaldo(valorSaque);

            Console.WriteLine("Dados da conta atualizados: " + conta);

            Console.ReadLine();


        }
    }
}