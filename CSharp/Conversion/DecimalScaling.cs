using static System.Console;
using static System.Convert;

public class Program {
    public static void Main() {
        var campo = "000001010";
        decimal valor = ToInt32(campo) / 100M;
        WriteLine(valor);
    }
}

//https://pt.stackoverflow.com/q/248631/101
