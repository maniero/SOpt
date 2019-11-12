using static System.Console;
using System.Globalization;

public class Program {
	public static void Main() {
		var valor = "9.5789";
		WriteLine($"Custo: R${valor:C2}");
   		WriteLine($"Custo: R${valor:C2}".ToString(new CultureInfo("pt-BR")));
   		WriteLine(string.Format("Custo: R${0:C2}", valor, new CultureInfo("pt-BR")));
 	}
}

//https://pt.stackoverflow.com/q/420881/101
