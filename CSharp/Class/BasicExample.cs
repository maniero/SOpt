using static System.Console;

public class Program {
    public static void Main(string[] args) {
		var conta = new Conta(1, "Joao", 100M);
		WriteLine(conta.Sacar(103.45M) ? $"Saque realizado, saldo restante {conta.Saldo}" : "Não foi possível sacar");
		conta.Depositar(50.0M);
		conta.Titular = "Joao da Silva";
		WriteLine(conta.Sacar(103.45M) ? $"Saque realizado, saldo restante {conta.Saldo}" : "Não foi possível sacar");
		WriteLine($"Número: {conta.Numero}");
		WriteLine($"Titular da conta: {conta.Titular}");
		WriteLine($"Saldo: {conta.Saldo}");
    }
}

public class Conta {
	public int Numero { get; set; }
	public string Titular { get; set; }
	public decimal Saldo { get; set; }
	public Conta(int numero, string titular, decimal saldo) {
		Numero = numero;
		Titular = titular;
		Saldo = saldo;
	}
	public void Depositar(decimal valor) => Saldo += valor;

	public bool Sacar(decimal valor) {
		if (Saldo - valor >= 0) {
			Saldo -= valor;
			return true;
		}
		return false;
	}
}

//https://pt.stackoverflow.com/q/204575/101
