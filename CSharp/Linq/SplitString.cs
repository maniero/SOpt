using static System.Console;
using System.Collections.Generic;
using System.Linq;

public class Program {
	public static void Main() {
		var lista = new List<string> { "1,Joao",
			"2,Maria",
			"3,José1" };
		var nome = lista.Select(x => x.Split(',')).SingleOrDefault(a => a[1].Contains("1"));
		var id = lista.Select(x => x.Split(',')).SingleOrDefault(a => a[0].Contains("1"));
		WriteLine(nome[1]);
		WriteLine(id[1]);
	}
}

//https://pt.stackoverflow.com/q/345563/101
