using static System.Console;
					
public class Program {
	public static void Main() {
		WriteLine(EhPalindromo("4004"));
		WriteLine(EhPalindromo("4002"));
	}
	public static bool EhPalindromo(string texto) {
	    for (int i = texto.Length - 1; i > texto.Length / 2; i--) {
			if (texto[i] != texto[texto.Length - i - 1]) {
				return false;
			}
        }
		return true;
	}
}

//https://pt.stackoverflow.com/q/85688/101
