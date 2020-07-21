using static System.Console;
using System.Collections.Generic;

public class Program {
    public static void Main() {
        var listaProdutos = ListaProdutos.GetList();
        foreach (var produto in listaProdutos) WriteLine($"{produto.Nome} -> {produto.PrecoVenda:C}");
    }
}

public class ListaProdutos {
    public static List<Produto> GetList() => new List<Produto>() {
            new Produto(id : 1, nome : "Arroz", precoCusto : 12, unidade : Produto.TipoDeUnidade.Kg, quantidade : 9),
            new Produto(2, "Leite", Produto.TipoDeUnidade.Litro, 5, 6)
        };
}

public class Produto {
    public int Id { get; }
    public string Nome { get; set; }
    public TipoDeUnidade Unidade { get; set; }
    public decimal Quantidade { get; }
    public decimal PrecoCusto { get; set; }
    public decimal PrecoVenda { get => PrecoCusto * (4M / 3M); }

    public Produto(int id, string nome, TipoDeUnidade unidade, decimal quantidade, decimal precoCusto) {
        Id = id;
        Nome = nome;
        Unidade = unidade;
        Quantidade = quantidade;
        PrecoCusto = precoCusto;
    }

    public enum TipoDeUnidade { Unidade, Litro, Balde, Par, Kg }
}

//https://pt.stackoverflow.com/q/302390/101
