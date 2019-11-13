using static System.Console;
using System.Globalization;
					
public class Program {
	public static void Main() {
		if (decimal.TryParse("0,05", NumberStyles.Number, new CultureInfo("pt-BR"), out var valor)) WriteLine(valor);
	}
}

//https://pt.stackoverflow.com/q/106672/101
