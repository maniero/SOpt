using static System.Console;
using System.Linq;

public class Program {
    public static void Main() {
        WriteLine(Teste("João", "048", "abc"));
        WriteLine(Teste("João", "048", "abc", ""));
        WriteLine(Teste("", "João", "048", "abc"));
        WriteLine(Teste("", null));
        WriteLine(Teste2("", null));
        WriteLine(Teste2("", null, "João", "048", "abc"));
    }
    public static bool Teste(params string[] textos) {
        foreach (var item in textos) if (!string.IsNullOrWhiteSpace(item)) return true;
        return false;
    }
    public static bool Teste2(params string[] textos) => textos.Any(item => !string.IsNullOrWhiteSpace(item));
}

//https://pt.stackoverflow.com/q/271330/101
