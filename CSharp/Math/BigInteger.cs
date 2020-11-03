using static System.Console;
using System.Numerics;

public class Program {
	public static void Main() {
		BigInteger num1 = 290287121823;
		BigInteger num2 = 538783;
		BigInteger resultado = BigInteger.Pow(num1, 2) + num2;
		WriteLine(resultado);
		WriteLine(resultado.ToString(".#"));
		WriteLine(resultado.ToString("N0"));
		WriteLine(resultado.ToString("F0"));
	}
}

//https://pt.stackoverflow.com/q/138226/101
