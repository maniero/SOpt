using static System.Console;
using System.Linq;
					
public class Program {
	public static void Main() {
		var list = new[] { new { Codigo = "Codigo", Servico = "Servico", Quantidade = "Quantidade", Preco = "Preco" } }.ToList();
		WriteLine(list[0].Codigo);
	}
}

//https://pt.stackoverflow.com/q/105776/101
