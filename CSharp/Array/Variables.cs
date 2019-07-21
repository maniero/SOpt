using static System.Console;

public class Program {
	public static void Main() {
		var teste = new string[] {"valor", "outro valor", "mais um valor" };
		for (var i = 0; i < 3;i++) teste[i] = "mudou " + i;
		foreach(var item in teste) WriteLine(item );
	}
}

//https://pt.stackoverflow.com/q/397532/101
