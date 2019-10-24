using static System.Console;

public class Program {
	public static void Main() {
		if (int.TryParse("5", out var limite) && limite > 0 && limite < 50) for (var i = 1.0; i <= limite; i++) WriteLine($"{i/(i + 1):F2}");
		else WriteLine("Digite um número válido");
	}
}

//https://pt.stackoverflow.com/q/417766/101
