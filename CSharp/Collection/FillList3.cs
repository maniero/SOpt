using static System.Console;
using System.Collections.Generic;
using System.Linq;
					
public class Program {
	public static void Main() {
		var lista = CriarCompras(10);
		lista[0].Item = 1;
		foreach (var item in lista) WriteLine(item.Item);
	}
	private static List<Compra> CriarCompras(int numComprasParaGerar) {
		var lstCompras = new List<Compra>();
		lstCompras.AddRange(Enumerable.Repeat(new Compra(), numComprasParaGerar));
		return lstCompras;
    }
}

public class Compra {
	public int Item = 0;
}

//https://pt.stackoverflow.com/a/89648/101
