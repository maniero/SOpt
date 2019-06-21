using static System.Console;
using System.Globalization;

public class Program {
	public static void Main() {
		decimal valor;
		if (decimal.TryParse("123.45", out valor)) WriteLine(valor);
		if (decimal.TryParse("123,45", NumberStyles.AllowCurrencySymbol | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands, new CultureInfo("pt-BR"), out valor)) {
		    WriteLine(valor);
		}
	}
}

//https://pt.stackoverflow.com/q/48409/101
