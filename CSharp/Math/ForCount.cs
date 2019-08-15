using static System.Console;
using System.Collections.Generic;
					
public class Program {
	public static void Main() {
		var lista = new List<int>();
		for (var i = 0; i < 10; i++) lista.Add(i);
		for (var i = 0; i < lista.Count; i++) WriteLine(lista[i]);
		for (var i = 0; i <= lista.Count - 1; i++) WriteLine(lista[i]);
	}
}

//https://pt.stackoverflow.com/q/54115/101
