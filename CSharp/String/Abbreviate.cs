using static System.Console;
using System;

public class Program {
	public static void Main() {
		WriteLine(Abreviatte("Rafael Rodrigues Arruda de Oliveira"));
		WriteLine(Abreviatte("Rafael Rodrigues Arruda De Oliveira"));
	}
	public static string Abreviatte(string nome) {
		var meio = " ";
		var nomes = nome.Split(' ');
		for (var i = 1; i < nomes.Length - 1; i++) {
			if (!nomes[i].Equals("de", StringComparison.OrdinalIgnoreCase) &&
				!nomes[i].Equals("da", StringComparison.OrdinalIgnoreCase) &&
				!nomes[i].Equals("do", StringComparison.OrdinalIgnoreCase) &&
				!nomes[i].Equals("das", StringComparison.OrdinalIgnoreCase) &&
				!nomes[i].Equals("dos", StringComparison.OrdinalIgnoreCase))
				    meio += nomes[i][0] + ". ";
		}
		return nomes[0] + meio + nomes[nomes.Length - 1];
	}
}

//https://pt.stackoverflow.com/q/366582/101
