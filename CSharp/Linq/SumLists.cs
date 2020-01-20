using static System.Console;
using System.Collections.Generic;
using System.Linq;
					
public class Program {
	public static void Main() {
		IList<VendaDevolucao> vendas = new List<VendaDevolucao>() {
			new VendaDevolucao { Id = 100, Venda = 230.00, Devolucao = 0 },
			new VendaDevolucao { Id = 100, Venda = 0, Devolucao = 50.00 },
			new VendaDevolucao { Id = 101, Venda = 515.00, Devolucao = 0 },
			new VendaDevolucao { Id = 101, Venda = 0, Devolucao = 42.00 },
		};		
		var junta = vendas.GroupBy(x => x.Id)
			.Select(x => new {
                Id = x.First().Id,
                Venda = x.Sum(v => v.Venda),
                Devolucao = x.Sum(v => v.Devolucao)
            });
		foreach (var item in junta.ToList()) WriteLine($"{item.Id} -> {item.Venda}, {item.Devolucao}");
	}
}

public class VendaDevolucao {
    public virtual int Id { get; set; }
    public virtual double Venda { get; set; }
    public virtual double Devolucao { get; set; }
}

//https://pt.stackoverflow.com/q/134044/101
