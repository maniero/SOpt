using System;
using static System.Console;
using System.Collections.Generic;

public class Program {
	public static void Main() {
		var list = new List<string>() { "Leão", "Guepardo", "Elefante" };
		var array = new string[3] { "Leão", "Guepardo", "Elefante" };
		WriteLine(list.IndexOf("Elefante"));
		WriteLine(Array.IndexOf(array, "Elefante"));
	}
}

//https://pt.stackoverflow.com/q/321203/101
