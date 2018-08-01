using System;
using static System.Console;

public class Program {
	public static void Main() {
		WriteLine(((DateTimeOffset)DateTime.UtcNow).ToUnixTimeMilliseconds());
	}
}

//https://pt.stackoverflow.com/q/319339/101
