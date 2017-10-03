using static System.Console;
using System.Text;

public class Program {
	public static void Main() {
		Write("Informe um número inteiro para ser invertido: ");
		var texto = ReadLine();
		if (!int.TryParse(texto, out var numero) && numero >= 0) return;
		var invertido = new StringBuilder(texto.Length);
		for(int i = texto.Length - 1; i >= 0; i--) invertido.Append(texto[i]);
		WriteLine(invertido);
	}
}

//https://pt.stackoverflow.com/q/242302/101
