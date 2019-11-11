using static System.Console;
public class Program {
	public static void Main() => WriteLine(Valor.Arredondar(123.456M, 2));
}

public static class Valor {
    public static decimal Arredondar(decimal valor, int casasDecimais) => decimal.Round(valor, casasDecimais);

    public static decimal? Arredondar(decimal? valor, int casasDecimais) {
        if (valor == null) return null;
        return Arredondar(valor.Value, casasDecimais);
    }
}

//https://pt.stackoverflow.com/q/104297/101
