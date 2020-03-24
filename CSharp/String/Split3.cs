using static System.Console;
using System;
					
public class Program {
	public static void Main() {
		var texto = "'Coluna 1' 'Coluna 2' 'Coluna 3'";
		texto = texto.Substring(1, texto.Length - 2);
		var items = texto.Split(new string[] {"' '"}, StringSplitOptions.None);
		foreach (var item in items) WriteLine(item);
	}
}

//https://pt.stackoverflow.com/q/167885/101
