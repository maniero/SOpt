using static System.Console;

public class Program {
	public static void Main() {
		for (var iA = 0; iA <= 30; iA++) {
			if (iA % 3 == 0 || iA % 4 == 0) {
				WriteLine(iA + " é múltiplo de 3 ou de 4");
			}
		}
	}
}

//https://pt.stackoverflow.com/q/199299/101
