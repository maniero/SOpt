using static System.Console;

public class Program {
	public static void Main() {
		Write("Digite um numero de 4 digitos: ");
		var numero = ReadLine();
		var soma = 0;
		foreach (var chr in numero) {
			if (!char.IsDigit(chr)) {
				WriteLine("não é um número válido");
				return;
			}
			soma += chr - '0';
		}
		WriteLine($"Soma dos numeros = {soma}");
	}
}

//https://pt.stackoverflow.com/q/349771/101
