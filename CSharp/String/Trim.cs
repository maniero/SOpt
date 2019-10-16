using static System.Console;
					
public class Program {
	public static void Main() {
		var texto = " Hello World ";
		WriteLine($"Corta o fim: |{texto.TrimEnd()}|");
		WriteLine($"Corta o início: |{texto.TrimStart()}|");
		WriteLine($"Corta ambos: |{texto.Trim()}|");
		WriteLine($"Corta tudo: |{texto.Replace(" ", "")}|");
	}
}

//https://pt.stackoverflow.com/q/91113/101
