using static System.Console;

public class Program {
	public static void Main() {
		var texto = "ZACKSON MOREIRA MORGAN (zackson.morgan)";
		WriteLine(pegaTexto(texto));
		texto = "ZACKSON MOREIRA MORGAN (zackson.morgan";
		WriteLine(pegaTexto(texto));
		texto = "ZACKSON MOREIRA MORGAN (";
		WriteLine(pegaTexto(texto));
	}
	public static string pegaTexto(string texto) {
		texto += ")";
		texto = texto.Substring(texto.IndexOf("(") + 1);
		return texto.Substring(0, texto.IndexOf(")"));
	}
}

//https://pt.stackoverflow.com/q/54313/101
