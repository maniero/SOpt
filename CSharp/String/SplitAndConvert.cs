using System;
using System.Collections.Generic;
using System.Linq;
					
public class Program {
	public static void Main() {
		var lista = new List<string> { "12/10", "01/02", "123/12", "A/1", "4/5" };
		var listaClassificada = lista.OrderBy(x => ConversaoParcial(x));
		listaClassificada.ToList().ForEach(Console.WriteLine);
	}
	public static string ConversaoParcial(string texto) {
		int valor;
		string textoParcial = texto.Split('/', '-')[0];
		return int.TryParse(textoParcial, out valor) ? textoParcial.PadLeft(4, '0') : textoParcial.PadLeft(4, 'A');
	}
}

//http://pt.stackoverflow.com/q/180975/101
