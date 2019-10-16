using System;
using static System.Console;
					
public class Program {
	public static void Main() {
		for (var x = 0; x < 10; x++) {
			Write($"Contei {x} vezes - ");
			Write("Contei {0} vezes - ", x);
			WriteLine("Contei " + x.ToString() + " vezes");
		}
		WriteLine($"Hoje é {DateTime.Now.ToString("dd/MM/yyyy")}");
		var idade = 10;
		WriteLine($"Tem {idade:D3} ano{(idade == 1 ? "" : "s")}");
		var exemplo = "teste {idade}"; //suponha que ista string está vindo de um arquivo externo ou banco de dados
//		var texto = $exemplo; //isto não funciona.
	}
}

//https://pt.stackoverflow.com/q/91117/101
