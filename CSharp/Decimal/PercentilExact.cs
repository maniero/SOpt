using static System.Console;
using System.Collections.Generic;

public class Program {
	public static void Main() {
		foreach (var item in CalculaPercentuais(377.17M, new decimal[] { 33.0M, 33.0M, 34.0M })) WriteLine(item);
	}
	public static IEnumerable<decimal> CalculaPercentuais(decimal valor, IEnumerable<decimal> percentuais) {
		//decidi não validar se a soma dos percentuais dá 100 porque pode ser que isso não seja obrigatório
		var valores = new List<decimal>();
		foreach (var percentual in percentuais) valores.Add(decimal.Round(valor / 100.0M * percentual, 2));
		var soma = 0.0M;
		for (var i  = 0; i < valores.Count - 1; i++) soma += valores[i];
		valores[valores.Count - 1] = valor - soma;
		return valores;
	}
}

//https://pt.stackoverflow.com/q/398984/101
