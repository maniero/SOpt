using System;
using static System.Console;
using System.Collections.Generic;
					
public class Program {
	public static void Main() {
		var acoes = new List<Func<int>>();
		var a = 0;
		for (var i = 0; i < 5; i++) {
			a = i;
			acoes.Add(() => a * 2);
		}
		foreach (var acao in acoes) WriteLine(acao());
		acoes = new List<Func<int>>();
		for (var i = 0; i < 5; i++) {
			int b = i;
			acoes.Add(() => b * 2);
		}
		foreach (var acao in acoes) WriteLine(acao());
	}
}

//https://pt.stackoverflow.com/q/170393/101
