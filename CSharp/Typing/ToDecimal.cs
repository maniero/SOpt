using static System.Console;
using System.Collections.Generic;
using System.Linq;

public class Program {
    private static List<Informacao> informacoes = new List<Informacao>();
	public static void Main() {
		CadNovaPesquisa();
		CadNovaPesquisa();
		CalculaMedia();
	}
    public static void CadNovaPesquisa()   {
        var informacao = new Informacao();
        WriteLine("Informe seu salário bruto:");
        if (!decimal.TryParse(ReadLine(), out var salBruto)) return;
		informacao.SalBruto = salBruto;
        WriteLine("Informe a quantidade de filhos:");
        if (!int.TryParse(ReadLine(), out var numFilhos)) return;
		informacao.NumFilhos = numFilhos;
        informacoes.Add(informacao);
    }
    public static void CalculaMedia() {
        var total = informacoes.Sum(x => x.SalBruto);
		WriteLine($"TOTAL: {total} MEDIA: {total/informacoes.Count}");
    }
}

public class Informacao {
    public decimal SalBruto { get; set; }
    public int NumFilhos { get; set; }
}

//https://pt.stackoverflow.com/q/288051/101
