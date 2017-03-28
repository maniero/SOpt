using System;
					
public class Program {
	public static void Main() {
		int hora = DateTime.Now.Hour;
		var nome = "João";
		var saudacoes = new string[] { "Boa madrugada", "Bom dia", "Boa tarde", "Boa noite" };
		Console.WriteLine($"{saudacoes[hora / 6]} {nome}!");
	}
}

//http://pt.stackoverflow.com/q/193243/101
