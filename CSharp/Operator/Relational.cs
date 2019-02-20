using static System.Console;

public class Program {
	public static void Main() {
		var x = 1;
		WriteLine(x == 1 || x == 2);
		WriteLine(x == 1 || x != 2);
		WriteLine(x != 1 || x != 2);
		WriteLine(x == 1 && x == 2);
		WriteLine(x == 1 && x != 2);
		WriteLine(x != 1 && x != 2);
		WriteLine(x == 3 || x == 2);
		WriteLine(x == 3 || x != 2);
		WriteLine(x != 3 || x != 1);
		WriteLine(x == 3 && x == 2);
		WriteLine(x == 3 && x != 2);
		WriteLine(x != 3 && x != 2);
	}
}

//https://pt.stackoverflow.com/q/46086/101
