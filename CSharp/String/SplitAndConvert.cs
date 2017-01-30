using System;
using System.Collections.Generic;
using System.Linq;
					
public class Program {
	public static void Main() {
		var lista = new List<string> { "12/10", "01/02", "123/12", "4/5" };
		var listaClassificada = lista.OrderBy(x => Convert.ToInt32((x.Split('/', '-'))[0]));
		listaClassificada.ToList().ForEach(Console.WriteLine);
	}
}

//http://pt.stackoverflow.com/q/180975/101
