using static System.Console;
using System.Collections.Generic;
using System.Linq;
					
public class Program {
	public static void Main() {
		foreach (var item in CriarCompras(10)) WriteLine(item);
	}
	private static List<Compra> CriarCompras(int numComprasParaGerar) {
		var lstCompras = new List<Compra>();
		lstCompras.AddRange(Enumerable.Repeat(new Compra(), numComprasParaGerar));
		return lstCompras;
    }
}

public class Compra {}

//https://pt.stackoverflow.com/a/89648/101
