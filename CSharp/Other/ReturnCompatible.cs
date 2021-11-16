using static System.Console;

class Program {
	static void Main() {
		Write("Digite um número: ");
		if (int.TryParse(ReadLine(), out var numero)) return;
		WriteLine($"{ÉPositivo(numero)}");
	}
	public static bool ÉPositivo(int numero) => numero >= 0;
}

//https://pt.stackoverflow.com/q/415713/101
