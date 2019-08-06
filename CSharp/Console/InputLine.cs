using static System.Console;

public class Program {
	public static void Main() {
		Write("Informe o comprimento em metros: ");
        if (!double.TryParse(ReadLine(), out var comprimento)) return;
 		Write("Informe a largura em metros: ");
        if (!double.TryParse(ReadLine(), out var largura)) return;
        WriteLine($"A area é de {largura * comprimento} m²");
	}
}

//https://pt.stackoverflow.com/q/401756/101
