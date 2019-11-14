using static System.Console;
					
public class Program {
	public static void Main() {
		var teste = new Teste();
		teste.a = 1;
		teste.c = "abc".ToCharArray();
		WriteLine(teste.a);
		WriteLine(teste.c);
	}
}

struct Teste {
	public int a;
	public char[] c;
}

//https://pt.stackoverflow.com/q/106470/101
