using static System.Console;
					
public class Program {
	public static void Main() {
		var teste = new Teste(1, "abc");
		WriteLine(teste.Numero);
		WriteLine(teste.Texto);
	}
}

struct Teste {
	public int Numero  { get; }
	public string Texto  { get; }
	public Teste(int numero, string texto) {
		Numero = numero;
		Texto = texto;
	}
}

//https://pt.stackoverflow.com/q/106470/101
