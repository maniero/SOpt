using System;
using static System.Console;
using System.Collections.Generic;
					
public class Program {
	public static void Main() {
		var exemplo = "13032015joao";
		//o último elemento poderia ser 200, por exemplo
		//o que se for garantido que ele tenha o tamanho, evitaria o if no método
		var partes = SplitFixed(exemplo, new List<int>() {2, 2, 4, 0});
		foreach(var parte in partes) {
			WriteLine(parte);
		}
		//poderia fazer as conversões aqui e jogar nas variáveis individuais
		
		//alternativa com tipos, não sei se compensa o esforço
		//para fazer certo daria o mesmo trabalho que fazer manualmente
		//poucos casos esta forma seria realmente mais vantajosa e o ideal é que a conversão
		//fosse feita através de lambdas contendo o código de conversão e não com tipos
		var partes2 = SplitFixedTyped(exemplo, new List<Tuple<int, Type>>() {
			new Tuple<int, Type>(2, typeof(int)), 
			new Tuple<int, Type>(2, typeof(int)),
			new Tuple<int, Type>(4, typeof(int)),
			new Tuple<int, Type>(0, typeof(string))});
		foreach(var parte in partes2) {
			WriteLine("Dado: {0} - Tipo {1}", parte, parte.GetType());
		}
		
	}
	public static List<String> SplitFixed(string texto, List<int> tamanhos) {
		var partes = new List<String>();
		var posicao = 0;
		foreach(var tamanho in tamanhos) {
			if (tamanho > 0) { //padronizei que 0 significa que deve ir até o fim
			    partes.Add(texto.Substring(posicao, tamanho));
			} else {
				// o ideal é que não tenha essa parte e todos os tamanhos sejam definidos
				//o 0 só pode ser usado como último parâmetro.
			    partes.Add(texto.Substring(posicao));
			}
			posicao += tamanho;
		}
		return partes;
	}
	//esta implementação é um pouco ingênua, não funciona em todas as situações mas funciona com o básico
	public static List<object> SplitFixedTyped(string texto, List<Tuple<int, Type>> tamanhos) {
		var partes = new List<object>();
		var posicao = 0;
		foreach(var tamanho in tamanhos) {
			if (tamanho.Item1 > 0) { //padronizei que 0 significa que deve ir até o fim
			    partes.Add(Convert.ChangeType(texto.Substring(posicao, tamanho.Item1), tamanho.Item2));
			} else {
				// o ideal é que não tenha essa parte e todos os tamanhos sejam definidos
				//o 0 só pode ser usado como último parâmetro.
			    partes.Add(texto.Substring(posicao));
			}
			posicao += tamanho.Item1;
		}
		return partes;
	}
}

//https://pt.stackoverflow.com/q/54224/101
