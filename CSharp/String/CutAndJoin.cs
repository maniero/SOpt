using static System.Console;
					
public class Program {
	public static void Main() {
		var fone = "(12)34567-8901";
		WriteLine(fone.Substring(1, 2));
		WriteLine(fone.Substring(4, 5) + fone.Substring(10, 4));
	}
}

//https://pt.stackoverflow.com/q/162979/101
