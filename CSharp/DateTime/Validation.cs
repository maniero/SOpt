using System;
using static System.Console;
using System.Globalization;
					
public class Program {
	public static void Main() {
		if (!ValidaData("24/10/2016")) WriteLine("invalido");
		if (!ValidaHora("27:10:15")) WriteLine("invalido");
	}
	public static bool ValidaData(string maskdata) => DateTime.ParseExact(maskdata, "dd/MM/yyyy", CultureInfo.InvariantCulture) <= DateTime.Now.AddDays(-1);
	public static bool ValidaHora(string maskhora) => int.Parse(maskhora.Split(':')[0]) <= 24;
}

//https://pt.stackoverflow.com/q/138484/101
