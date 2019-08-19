using System;
using static System.Console;
using System.Collections.Generic;
					
public class Program {
	public static void Main() {
		var exemplo = "13032015joao14032015Juca23032015Joao24032015Jose";
		var partes = SplitBlocks(exemplo, 12);
		foreach(var parte in partes) WriteLine(parte);
		WriteLine();
		exemplo = "13032015joao14032015Juca23032015Joao24032015Jose1234";
		partes = SplitBlocksPartial(exemplo, 12);
		foreach(var parte in partes) {
			WriteLine(parte);
		}
	}
	public static List<String> SplitBlocks(string texto, int tamanho) {
		var partes = new List<String>();
		var posicao = 0;
		var total = texto.Length;
		while(total >= posicao + tamanho) {
		    partes.Add(texto.Substring(posicao, tamanho));
			posicao += tamanho;
		}
		return partes;
	}
	public static List<String> SplitBlocksPartial(string texto, int tamanho) {
		var partes = new List<String>();
		var posicao = 0;
		var total = texto.Length;
		while(total >= posicao) {
			if (total >= posicao + tamanho) partes.Add(texto.Substring(posicao, tamanho));
			else partes.Add(texto.Substring(posicao));
			posicao += tamanho;
		}
		return partes;
	}
}

//https://pt.stackoverflow.com/q/54235/101
