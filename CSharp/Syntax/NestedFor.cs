using static System.Console;

public class Program {
	public static void Main() {
		for (int n1 = 1; n1 < 11; n1++) {
			for (int n2 = 1; n2 < 11; n2++) WriteLine($"{n1:d2} x {n2:d2} = {n1 * n2:d2}");
			WriteLine();
		}
	}
}

//https://pt.stackoverflow.com/q/240882/101
