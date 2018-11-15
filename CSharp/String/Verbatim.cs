using static System.Console;

public class Program {
	public static void Main() {
		var nome = "João";
		WriteLine(@"Olá!
Como você está?");
		WriteLine($@"Olá {nome}!
Como você está?");
	}
}

//https://pt.stackoverflow.com/q/343600/101
