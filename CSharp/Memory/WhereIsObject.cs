using System;

public class Program {
	public static void Main() {
		var objeto = new object();
		Console.WriteLine($"Geração {GC.GetGeneration(objeto)}");
		GC.Collect();
		Console.WriteLine($"Geração {GC.GetGeneration(objeto)}");
		GC.Collect();
		Console.WriteLine($"Geração {GC.GetGeneration(objeto)}");
	}
}

//https://pt.stackoverflow.com/q/201086/101
