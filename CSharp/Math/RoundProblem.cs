using static System.Console;
					
public class Program {
	public static void Main() {
		double x = 0.0d;
		for (var i = 0; i < 1000; i++) x += 0.1d;
		WriteLine(x);
	}
}

//https://pt.stackoverflow.com/q/59010/101
