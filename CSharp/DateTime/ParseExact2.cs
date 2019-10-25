using System;
using System.Globalization;
					
public class Program {
	public static void Main() => Console.WriteLine(DateTime.ParseExact("sex, nov 6", "ddd, MMM d", new CultureInfo("pt-BR")));
}

//https://pt.stackoverflow.com/q/96670/101
