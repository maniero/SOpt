using static System.Console;

public class Program {
	public static void Main() {
		while (true) {
			WriteLine("Em que dia você nasceu?");
			if (int.TryParse(ReadLine(), out var dia) && dia < 32) break;
			WriteLine("Digite dia válido");
		}
		while (true) {
			WriteLine("Em que mês você nasceu?");
			if (int.TryParse(ReadLine(), out var dia) && dia < 13) break;
			WriteLine("Digite mês válido");
		}
	}
}

//https://pt.stackoverflow.com/q/432738/101
