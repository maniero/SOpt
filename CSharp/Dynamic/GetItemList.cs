using static System.Console;
using System.Dynamic;
using System.Collections.Generic;
					
public class Program {
	public static void Main() {
		dynamic obj = new ExpandoObject();
		obj.Codigo = "Código";
		obj.Servico = "Serviço";
		obj.Quantidade = "Quantidade";
		obj.Preco = "Preço";
		var listServicos = new List<dynamic>{ obj };
		WriteLine(listServicos[0].Codigo);
	}
}

//https://pt.stackoverflow.com/q/105776/101
