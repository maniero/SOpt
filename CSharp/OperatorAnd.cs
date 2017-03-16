using static System.Console;
					
public class Program {
	public static void Main() {
		var x = 1;
		var y = 2;
		var a = x & y;
		var b = x == 1;
		var c = y == 2;
		var d = x & y;
		var e = (x & y) == 0;
		WriteLine(a);
		WriteLine(d); //note que é um inteiro
		WriteLine(e);
		//if (x & y) WriteLine("ok"); //não funciona porque if espera um bool e o resultado é int
		if (b & c) WriteLine("ok"); else WriteLine(" não ok");
		if (Teste(x) & Teste(y)) WriteLine("&  - ok"); else WriteLine("&");
		if (Teste(x) && Teste(y)) WriteLine("&& - ok"); else WriteLine("&&");
		if (Teste(x) | Teste(y)) WriteLine("|  - ok"); else WriteLine("|");
		if (Teste(x) || Teste(y)) WriteLine("|| - ok"); else WriteLine("||");
		if (Teste(y) & Teste(x)) WriteLine("&  - ok"); else WriteLine("&");
		if (Teste(y) && Teste(x)) WriteLine("&& - ok"); else WriteLine("&&");
		if (Teste(y) | Teste(x)) WriteLine("|  - ok"); else WriteLine("|");
		if (Teste(y) || Teste(x)) WriteLine("|| - ok"); else WriteLine("||");
	}
	public static bool Teste(int x) {
		WriteLine($"Executou {x}");
		return x == 2;
	}
}

//http://pt.stackoverflow.com/q/190579/101
