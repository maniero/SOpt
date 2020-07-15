using static System.Console;
using static System.Math;

public class Program {
    public static void Main() {
        if (double.TryParse(ReadLine(), out var raio)) WriteLine($"A = {PI * Pow(raio, 2):N4}");
	}
}

//https://pt.stackoverflow.com/q/286350/101
