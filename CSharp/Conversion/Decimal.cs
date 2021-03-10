using static System.Console;
using static System.Convert;
using static System.Math;
using System.Globalization;

public class Program {
	public static void Main() {
		if (!decimal.TryParse("5.541,88", NumberStyles.Currency, CultureInfo.CreateSpecificCulture("pt-BR"), out var valor)) WriteLine("Formato inválido para conversão");
		WriteLine($"Decimal: {valor}");
		WriteLine($"Inteiro: {ToInt32(valor)}");
		WriteLine($"Inteiro truncado: {Truncate(valor)}");
		WriteLine($"Decimal truncado: {decimal.Truncate(valor)}");
	}
}

//https://pt.stackoverflow.com/q/498491/101
