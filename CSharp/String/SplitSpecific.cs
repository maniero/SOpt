using static System.Console;
using static System.Math;
using System;

public class Program {
	public static void Main() {
		var texto = @"13-00-00-00-73-63-63-64-5C-73-63-63-64-5F-61-78-74-72-65-65-30-30-31-13-00-00-00-73-63-63-64-5F-61-78-74-72-65-65-30-30-31-5F-";
		var divisoes = texto.Split(new[] { "13-00-00-00" }, StringSplitOptions.RemoveEmptyEntries);
		foreach (var divisao in divisoes) {
			foreach (var casa in divisao.Split(new[] {'-'})) WriteLine(casa);
			WriteLine("--");
		}
		WriteLine("Sem traços");
		texto = @"13000000736363645C736363645F61787472656530303113000000736363645F6178747265653030315F";
		divisoes = texto.Split(new[] { "13000000" }, StringSplitOptions.RemoveEmptyEntries);
		foreach (var divisao in divisoes) {
			for (var i = 0; i <= Min(divisao.Length - 1, 37); i+=2) WriteLine(divisao.Substring(i, 2));
			WriteLine("--");
		}
	}
}

//https://pt.stackoverflow.com/q/140085/101
