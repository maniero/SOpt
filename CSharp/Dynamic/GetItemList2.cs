using static System.Console;
using System.Linq;
					
public class Program {
	public static void Main() {
		var list = Enumerable.Empty<object>()
					 .Select(r => new { Codigo = "Codigo", Servico = "Servico", Quantidade = "Quantidade", Preco = "Preco" })
					 .ToList();
		list.Add(new { Codigo = "Codigo", Servico = "Servico", Quantidade = "Quantidade", Preco = "Preco" });
		WriteLine(list[0].Codigo);
	}
}

//https://pt.stackoverflow.com/q/105776/101
