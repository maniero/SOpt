using System;
using static System.Console;

public class Program {
	public static void Main() {
		WriteLine($"Date: {DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ssZ")}");
	}
}

//https://pt.stackoverflow.com/q/235696/101
