using static System.Console;
using static System.Convert;

public class Program {
    public static void Main() {
        Write("Cardeal 'N' 'S' 'L' 'O': ");
        var pCardeal = char.ToUpper(ToChar(ReadKey(false).Key.ToString()));
        WriteLine($"PosicaoCardinal {pCardeal}");
    }
}

//http://pt.stackoverflow.com/q/22193/101
