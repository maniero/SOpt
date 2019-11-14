using static System.Console;
using System.Collections.Generic;
					
public class Program {
	public static void Main() {
		var list = ToAnonymousList(new { Codigo = "Codigo", Servico = "Servico", Quantidade = "Quantidade", Preco = "Preco" });
		WriteLine(list[0].Codigo);
	}
	public static IList<T> ToAnonymousList<T>(params T[] items) => items;
}

//https://pt.stackoverflow.com/q/105776/101
