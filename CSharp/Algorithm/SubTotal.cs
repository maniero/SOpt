using static System.Console;
using System.Collections.Generic;
					
public class Program {
	public static void Main() {
		//as primeiras linhas abaixo é o mesmo que seria o método PegaContribuintes que eu usei no exemplo da resposta
		var pessoas = new List<Pessoa> { 
			new Pessoa { Nome = "Elias Vieira1", Contribuinte = 31.87m },
			new Pessoa { Nome = "Elias Vieira2", Contribuinte = 32.87m },
			new Pessoa { Nome = "Elias Vieira3", Contribuinte = 33.87m },
			new Pessoa { Nome = "Elias Vieira4", Contribuinte = 34.87m }
		};
		decimal subTotal = 0;
    	foreach (var item in pessoas) {
			subTotal += item.Contribuinte;
			item.SubTotal = subTotal;
			WriteLine($"Nome: {item.Nome}, Contribuição: {item.Contribuinte}, SubTotal: {item.SubTotal}");
		}
	}
}

public class Pessoa {
    public string Nome { get; set; }
    public decimal Contribuinte { get; set; }
    public decimal SubTotal { get; set; }
}

//https://pt.stackoverflow.com/q/53118/101
