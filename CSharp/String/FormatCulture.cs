using static System.Console;
using System.Globalization;
					
public class Program {
	public static void Main() {
		var numero = 896567M;
		var texto = string.Format(CultureInfo.CreateSpecificCulture("pt-BR"), "{0:F1}", numero / 1000);
		WriteLine(texto);
	}
}

//https://pt.stackoverflow.com/q/56654/101
