using static System.Console;
using static System.Convert;
using System.Linq;
					
public class Program {
	public static void Main() {
		WriteLine("O maior numero é " + Teste(4242));
		WriteLine("O maior numero é " + Teste(123));
		WriteLine("O maior numero é " + Teste(100009));
		WriteLine("O maior numero é " + Teste(10000000));
	}
	public static int Teste(int number) => number >= 10000000 ? -1 : ToInt32(new string(number.ToString().OrderByDescending(x => x).ToArray()));
}

//https://pt.stackoverflow.com/q/110892/101
