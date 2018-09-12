using static System.Console;
using static System.Math;

public class Program {
	public static void Main() {
		var maxAltura = -1.0;
		for (int i = 0; i < 10; i++) {
			WriteLine("Qual a sua altura: ");
			double altura;
			if (double.TryParse(ReadLine(), out altura) && altura > 0) maxAltura = Max(maxAltura, altura);
			else i--;
		}
		WriteLine(maxAltura);
	}
}

//https://pt.stackoverflow.com/q/320125/101
