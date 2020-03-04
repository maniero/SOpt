using System;
using static System.Console;
using System.Globalization;

public class Program {
	public static void Main() {
		var data = "9/14/2016 12:00:00 AM";
		var date = DateTime.Parse(data, new CultureInfo("en-US")); //pega a data no formato
		WriteLine(date.ToString("dd/MM/yyyy", new CultureInfo("pt-BR"))); //imprime no formato desejado
		DateTime date2; //variável que receberá o valor se a conversão for ok
		if (DateTime.TryParseExact(data, "M/d/yyyy hh:mm:ss tt", CultureInfo.InvariantCulture, DateTimeStyles.None, out date2)) {
			WriteLine(date2.ToString("dd/MM/yyyy", new CultureInfo("pt-BR"))); //imprime no formato desejado
		}
	}
}

//https://pt.stackoverflow.com/q/152781/101
