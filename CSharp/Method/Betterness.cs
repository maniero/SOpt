using static System.Console;

public class Program {
	public static void Main() {
		WriteLine("Digite um número com três dígitos");
		if (int.TryParse(ReadLine(), out var numero) && numero < 10000) {
			WriteLine($"{numero / 100} {(numero % 100) / 10} {(numero % 100) % 10}");
		}
	}
}

//https://pt.stackoverflow.com/q/244329/101
