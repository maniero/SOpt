using static System.Console;
public class Program {
	public static void Main() {
		var partes = "97A96D112A109X115T114H122D118Y128".Split("ABCDEFGHIJKLMNOPQRSTUVXWYZ".ToCharArray());
		foreach (var item in partes) WriteLine(item); //só para confirmar que deu certo
	}
}

//https://pt.stackoverflow.com/q/209214/101
