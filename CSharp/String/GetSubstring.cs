using static System.Console;
using static System.Math;

public class Program {
	public static void Main() {
		var texto = "teste 1";
		WriteLine(texto.Substring(0, Min(texto.Length, 48)));
		texto = "teste 1, teste 2, teste 3, teste 4, teste 5, teste 6, teste 7";
		WriteLine(texto.Substring(0, Min(texto.Length, 48)));
	}
}

//https://pt.stackoverflow.com/q/43048/101
