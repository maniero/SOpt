using static System.Console;

public static class MinhasExtensions {
	public static string Adiciona(string s) => s + " Adicionei algo aqui";
	public static string AdicionaExt(this string s) => s + " Adicionei algo aqui";
}
					
public class Program {
	public static void Main() {
		WriteLine(MinhasExtensions.Adiciona("Wallace de Souza"));
		WriteLine("Wallace de Souza".AdicionaExt());
	}
}

//https://pt.stackoverflow.com/q/125601/101
