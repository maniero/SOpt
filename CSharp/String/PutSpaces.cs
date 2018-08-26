using static System.Console;
using System.Text;

public class Program {
    public static void Main() {
        var frase = "Alguma coisa";
        var espacado = new StringBuilder(frase.Length * 2 - 1);
		for (var i = 0; i < frase.Length; i++) {
			if (frase[i] != ' ' && (i < 1 || frase[i - 1] != ' ')) espacado.Append(' ');
			espacado.Append((i < 1 || frase[i - 1] == ' ') ? char.ToUpper(frase[i]) : frase[i]);
        }
        WriteLine(espacado);
    }
}

//https://pt.stackoverflow.com/q/325041/101
