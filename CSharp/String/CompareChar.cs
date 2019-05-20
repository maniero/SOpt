using static System.Console;

public class Program {
	public static void Main() {
		WriteLine(eNumero(""));
		WriteLine(eNumero("a"));
		WriteLine(eNumero("5"));
	}
	public static bool eNumero(string s) {
		if (string.IsNullOrWhiteSpace(s)) return false;
		return (int)s[0] >= (int)'0' && (int)s[0] <= (int)'9';
	}
}

//https://pt.stackoverflow.com/q/385165/101
