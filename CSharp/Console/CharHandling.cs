using static System.Console;
using static System.Convert;

public class Program {
    public static void Main() {
        Write("Cardeal 'N' 'S' 'L' 'O': ");
        var pCardeal = char.ToUpper(ToChar(ReadLine()));
        WriteLine($"PosicaoCardinal {pCardeal}");
    }
}

//https://pt.stackoverflow.com/q/22193/101
