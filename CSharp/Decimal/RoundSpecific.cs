using static System.Console;
public class Program {
	public static void Main() {
		WriteLine(123.456789M.Arredondar(2));
		WriteLine(((decimal?)123.456789M)?.Arredondar(3));
		WriteLine(decimal.Round(123.456789M, 4));
		WriteLine(((decimal?)null)?.Arredondar(5));
	}
}

public static class DecimnalExt {
    public static decimal Arredondar(this decimal valor, int casasDecimais) => decimal.Round(valor, casasDecimais);
}

//https://pt.stackoverflow.com/q/104297/101
