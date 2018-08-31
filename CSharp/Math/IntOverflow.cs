using static System.Console;

public class Program {
	public static void Main() {
		for (int i = 1; i >= 0; i *= 2) { WriteLine($"i: {i}"); }
		checked {
			for (int j = 1; j >= 0; j *= 2) { WriteLine($"j: {j}"); }
		}
	}
}

//https://pt.stackoverflow.com/q/326539/101
