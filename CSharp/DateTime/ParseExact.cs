using System;
using static System.Console;
using System.Globalization;

public class Program {
	public static void Main() {
		WriteLine(DateTime.ParseExact("16Mar2009(mon)", "ddMMMyyyy(ddd)", CultureInfo.InvariantCulture));
	}
}

//https://pt.stackoverflow.com/q/47673/101
