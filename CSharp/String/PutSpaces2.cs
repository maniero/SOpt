using static System.Console;
using System.Text;

public class Program {
    public static void Main() {
        var frase = " Alguma coisa ";
        var espacado = new StringBuilder(frase.Length * 2 - 1);
        var primeiro = true;
        for (var i = 0; i < frase.Length; i++) {
            if (frase[i] == ' ') continue;
            if (!primeiro) {
                espacado.Append(' ');
            }
            primeiro = false;
            espacado.Append((i == 0 || frase[i - 1] == ' ') ? char.ToUpper(frase[i]) : char.ToLower(frase[i]));
        }
        WriteLine("|" + espacado + "|");
    }
}

//https://pt.stackoverflow.com/q/325041/101
