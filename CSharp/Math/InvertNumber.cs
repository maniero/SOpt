using static System.Console;

public class Program {
	public static void Main() {
		Write("Informe um número inteiro para ser invertido: ");
		if (!int.TryParse(ReadLine(), out var numero) && numero >= 0) return;
		var invertido = 0;
		while (numero > 0) {
		   invertido = invertido * 10 + numero % 10;
		   numero /= 10;
		}
		WriteLine(invertido);;
	}
}

//https://pt.stackoverflow.com/q/242302/101
