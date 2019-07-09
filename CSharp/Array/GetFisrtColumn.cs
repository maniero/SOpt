using static System.Console;

public class Program {
	public static void Main() {
		string[,] operacoes = { 
		   { "SOMA", "x", "" },
		   { "SUBTRAÇÃO", "x", "" },
		   { "MULTIPLICAÇÃO", "x", "" },
		   { "DIVISÃO", "x", "" }
		};
		for (var i = 0; i < operacoes.GetLength(0); i++) WriteLine(operacoes[i, 0]);
	}
}

//https://pt.stackoverflow.com/q/396160/101
