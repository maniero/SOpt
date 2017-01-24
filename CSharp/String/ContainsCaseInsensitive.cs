using System;
					
public class Program {
	public static void Main() {
		Console.WriteLine("Aqui tem uma STRING para ser localizada".IndexOf("string", StringComparison.OrdinalIgnoreCase) >= 0);
	}
}

//http://pt.stackoverflow.com/q/179568/101
