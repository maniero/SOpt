using static System.Console;

public class Program {
	public static void Main() {
		Imprime();
		WriteLine(Executa());
		WriteLine(Executa2());
	}
	
	public static void Imprime() => WriteLine("ok");
	public static string Executa() => "texto";
	//public static bool Teste2() => WriteLine("ok2"); return true; //daria erro
	
	public static string Executa2() { //é a mesma coisa
		return "texto";
	}
}

//https://pt.stackoverflow.com/q/206998/101
