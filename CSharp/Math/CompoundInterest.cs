using static System.Console;
using static System.Math;

public class Program {
	public static void Main() => WriteLine(CalculatesInterest(100M, 5, 0.01M));
	public static decimal CalculatesInterest(decimal valorInicial, int meses, decimal juros) => decimal.Round(valorInicial * (decimal)Pow(1.0 + (double)juros, meses), 2);
}

//https://pt.stackoverflow.com/q/443699/101
