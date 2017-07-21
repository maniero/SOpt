using System;
using static System.Console;
using System.IO;

public class Program {
	public static void Main(string[] args) {
		var texto = "2\n0.03159527 0.1990048 0.9794891\n0.02173799 0.9969404 0.07508247";
		using (var reader = new StringReader(texto)) { //só trocar para o arquivo aqui
			int size = int.Parse(reader.ReadLine());
			for (int i = 0; i < size; i++) {
				string[] linha = reader.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
				WriteLine($"{linha[0]}, {linha[1]}, {linha[2]}"); //depois troca para o Vector3
			}
		}
	}
}

//https://pt.stackoverflow.com/q/222295/101
