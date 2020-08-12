using static System.Console;
using System;

namespace Projeto {
    public class Program {
        public static void Main() {
            Conta conta = new Conta();
            Write("Entre com o numero da conta: ");
            if (!int.TryParse(ReadLine(), out var numero)) return;
			conta.Numero = numero;
            WriteLine();
            Write("Entre com o nome: ");
            conta.Nome = ReadLine();
            WriteLine();
            Write("Haverá um deposito inicial (s/n)? :  ");
            var temDeposito = ReadLine();
			var valor = 0M;
            if (temDeposito.Equals("S", StringComparison.CurrentCultureIgnoreCase)) {
                Write("Entre com o valor depositado: ");
                if (!decimal.TryParse(ReadLine(), out valor)) return;
            }
            conta.Saldo = valor;
        }
    }
	
	public class Conta {
		public int Numero { get; set; }
		public string Nome { get; set; }
		public decimal Saldo { get; set; }
	}
}

//https://pt.stackoverflow.com/q/467288/101
