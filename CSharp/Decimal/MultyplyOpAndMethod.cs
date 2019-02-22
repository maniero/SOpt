using static System.Console;

public class Program {
	public static void Main() {
		WriteLine(decimal.Multiply(50.40M, 3));
		WriteLine(50.40M * 3);
//		WriteLine(decimal.Multiply(50.40, 3));
		WriteLine(50.40 * 3);
		WriteLine(decimal.Multiply(50, 3).GetType());
		WriteLine((50 * 3).GetType());
//		decimal x = 1_000_000 * 1_000_000;
		decimal x = decimal.Multiply(1_000_000, 1_000_000);
	}
}

//https://pt.stackoverflow.com/q/364116/101
