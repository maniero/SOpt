using System;
using static System.Console;
using static System.Math;

public class Program {
    public static void Main() {
        WriteLine("Decimal");
        for (var valor = -1M; valor <= 1M; valor += 0.05M) WriteLine("{0:N1} => {1:N1}", valor, valor.RoundMidPoint());
        WriteLine("Double");
        for (var valor = -1.0; valor <= 1.0; valor += 0.05) WriteLine("{0:N1} => {1:N1}", valor, valor.RoundMidPoint());
    }
}

public static class RoundUtil {
    public static Decimal RoundMidPoint(this Decimal value) => Sign(value) * Ceiling(Abs(value) * 2) / 2;

    public static double RoundMidPoint(this double value) => Sign(value) * Ceiling(Abs(value) * 2) / 2;
}

//http://pt.stackoverflow.com/q/16185/101
