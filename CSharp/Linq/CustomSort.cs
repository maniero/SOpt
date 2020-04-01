using System.Collections.Generic;
using System.Linq;
using static System.Console;
					
public class Program {
	public static void Main() {
		var lista = new List<string> { "1.01", "1.A", "14.04", "14.11", "22.01", "3.04", "30.01", "4.01", "40.02" };
		foreach (var item in lista.OrderBy(i => { var partes = i.Split('.'); return partes[0].PadLeft(2) + partes[1]; })) {
			WriteLine(item);
		}
	}
}

//https://pt.stackoverflow.com/q/172424/101
