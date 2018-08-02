using static System.Console;
using System.Collections.Generic;
using System.Linq;

public class Program {
	public static void Main(string[] args) {
		var lista = new List<Dados>() { new Dados { Campo1 = true, Campo2 = false, Campo3 = true, Campo4 = true },
				new Dados {	Campo1 = false,	Campo2 = false,	Campo3 = true, Campo4 = false }	};
		WriteLine(lista.Select(x => (x.Campo1 ? 1 : 0) + (x.Campo2 ? 1 : 0) + (x.Campo3 ? 1 : 0) + (x.Campo4 ? 1 : 0)).ToList()[0]);
		WriteLine(lista.Sum(x => (x.Campo1 ? 1 : 0) + (x.Campo2 ? 1 : 0) + (x.Campo3 ? 1 : 0) + (x.Campo4 ? 1 : 0)));
	}
}

public class Dados {
	public bool Campo1 { get; set; }
	public bool Campo2 { get; set; }
	public bool Campo3 { get; set; }
	public bool Campo4 { get; set; }
}

//https://pt.stackoverflow.com/q/319066/101
