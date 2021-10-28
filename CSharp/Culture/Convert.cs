using System;
using System.Globalization;

public class Program {
	public static void Main() {
		if (!DateTime.TryParse("29/01/2018", new CultureInfo("pt-BR"), DateTimeStyles.None, out var data)) Console.WriteLine("ERRO NA CONVERSAO");
	}
}

//https://pt.stackoverflow.com/q/333031/101
