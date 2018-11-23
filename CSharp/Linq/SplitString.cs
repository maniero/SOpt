using static System.Console;
using System.Collections.Generic;
using System.Linq;

public class Program {
	public static void Main() {
		var lista = new List<string> { "1,Joao",
			"2,Maria",
			"3,José1" };
		var item = lista.Select(x => x.Split(',')).SingleOrDefault(a => a[1].Contains("1"));
		WriteLine(item[1]);
	}
}

//
