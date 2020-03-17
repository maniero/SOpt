using static System.Console;

public class Program {
	public static void Main() {
		var x = double.MaxValue;
		double y = 0;
		if (!double.IsPositiveInfinity(x * 2)) y = x * 2;
		Write(y);
	}
}

//https://pt.stackoverflow.com/q/159776/101
