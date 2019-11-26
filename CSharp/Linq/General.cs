using static System.Console;
using System.Collections.Generic;
using System.Linq;
					
public class Program {
	public static void Main() {
		var produtos = new List<Produto> { new Produto {ProdutoId = 1, Descricao = "P1", Preco = 10.00M, Estoque = 10 },
		                                   new Produto {ProdutoId = 2, Descricao = "P2", Preco = 20.00M, Estoque = 20 }};
		var filtrado = Lista(produtos);
		foreach (var produto in filtrado) WriteLine(produto.ProdutoId);
		filtrado = FiltreNome(produtos, "P2");
		WriteLine("Filtrado");
		foreach (var produto in filtrado) WriteLine(produto.ProdutoId);
	}
	public static IEnumerable<Produto> Lista(IEnumerable<Produto> produtos) {
		return from p in produtos
			select new Produto {
				ProdutoId = p.ProdutoId,
				Descricao = p.Descricao,
				Preco = p.Preco,
				Estoque = p.Estoque
			};
	}
	public static IEnumerable<Produto> FiltreNome(IEnumerable<Produto> produtos, string descricao) {
		var query = from p in produtos
            where p.Descricao.StartsWith(descricao)
			select p;
		return Lista(query);
	}
}

public class Produto {
	public int ProdutoId;
	public string Descricao;
	public decimal Preco;
	public int Estoque;
}

//https://pt.stackoverflow.com/q/108757/101
