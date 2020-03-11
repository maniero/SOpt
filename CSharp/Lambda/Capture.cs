using static System.Console;
using System;
using System.Collections.Generic;

public class Program {
	public static void Main() {
		var lista = new List<Action>();
		for (var i = 0; i < 10; i++) lista.Add(() => WriteLine(i));
		for (var c = 0; c < 10; c++) Metodo(lista[c]);
		var lista2 = new List<Action>();
		for (var i = 0; i < 10; i++) {
			var tmp = i;
			lista2.Add(() => WriteLine(tmp));
		}
		for (var c = 0; c < 10; c++) Metodo(lista2[c]);
	}
	public static void Metodo(Action func) => func();
}

//https://pt.stackoverflow.com/q/156764/101
