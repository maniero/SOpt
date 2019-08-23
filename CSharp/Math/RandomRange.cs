using System;
using static System.Console;
					
public class Program {
	public static void Main() {
		var rand = new Random();
		for (int i = 0; i < 10; i++) {
			WriteLine(rand.Next(10000, 99999));
		}
		WriteLine();
		for (int i = 0; i < 10; i++) {
			rand = new Random();
			WriteLine(rand.Next(10000, 99999));
		}
	}
}

//https://pt.stackoverflow.com/q/55701/101
