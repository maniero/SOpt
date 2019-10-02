using static System.Console;

public class Program {
	public static void Main() {
		var soma = 0;
        foreach (var i in { 3, 7, -6, 10, -1, 0, -1, 4}) if (i > 0) soma++;
        WriteLine("Soma: " + soma);
	}
}

//https://pt.stackoverflow.com/q/413495/101
