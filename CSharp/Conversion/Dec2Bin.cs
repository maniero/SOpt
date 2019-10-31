using static System.Console;
using System.Numerics;
					
public class Program {
	public static void Main() => WriteLine(DecimalParaBinario(BigInteger.Parse("1231231231231231231231231232312312312")));
	static string DecimalParaBinario(BigInteger n) {
		BigInteger resto;
		var result = "";
		while (n > 0) {
			resto = n % 2;
			n /= 2;
			result = resto.ToString() + result;
		}
		return result.ToString();
	}
}

//https://pt.stackoverflow.com/q/101472/101
