using static System.Console;

public class Program {
	public static void Main() {
		dynamic x = 1;
		WriteLine(x.GetType());
		x = "oi";
		WriteLine(x.GetType());
	}
}

//https://pt.stackoverflow.com/q/161729/101
