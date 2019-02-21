using static System.Console;
					
public class Program {
	public static void Main(string[] args) {
		var dividir = 1m;
		for (var i = 1; dividir != 0; i++) {
			WriteLine($"{i}:{(dividir /= 2m)}");
		}
	}
}

//https://pt.stackoverflow.com/q/47003/101
