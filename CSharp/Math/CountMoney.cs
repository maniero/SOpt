using static System.Console;

public class Program {
	public static void Main() {
		if (!decimal.TryParse(ReadLine(), out var n)) return;
		var resto = (int)(n * 100);
		WriteLine("NOTAS:");
		WriteLine($"{resto / 10000} nota(s) de R$ 100.00");
		resto %= 10000;
		WriteLine($"{resto / 5000} nota(s) de R$ 50.00");
		resto %= 5000;
		WriteLine($"{resto / 2000} nota(s) de R$ 20.00");
		resto %= 2000;
		WriteLine($"{resto / 1000} nota(s) de R$ 10.00");
		resto %= 1000;
		WriteLine($"{resto / 500} nota(s) de R$ 5.00");
		resto %= 500;
		WriteLine($"{resto / 200} nota(s) de R$ 2.00");
		WriteLine("MOEDAS:");
		resto %= 200;
		WriteLine($"{resto / 100} moeda(s) de R$ 1.00");
		resto %= 100;
		WriteLine($"{resto / 50} moeda(s) de R$ 0.50");
		resto %= 50;
		WriteLine($"{resto / 25} moeda(s) de R$ 0.25");
		resto %= 25;
		WriteLine($"{resto / 10} moeda(s) de R$ 0.10");
		resto %= 10;
		WriteLine($"{resto / 5} moeda(s) de R$ 0.05");
		resto %= 5;
		WriteLine($"{resto} moeda(s) de R$ 0.01");
	}
}

//https://pt.stackoverflow.com/q/364588/101
