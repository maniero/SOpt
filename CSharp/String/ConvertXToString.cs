using static System.Console;
using System;
					
public class Program {
	public static void Main() {
		int? x = null;
		int y = 10;
		string z = null; //só como exemplo, não faz sentido converter string p/ string
		try {
			WriteLine($"Convert.ToString(x) = {Convert.ToString(x)}");
			WriteLine($"Convert.ToString(y) = {Convert.ToString(y)}");
			WriteLine($"Convert.ToString(z) = {Convert.ToString(z)}");
			WriteLine($"x.ToString() = {x.ToString()}");
			WriteLine($"y.ToString() = {y.ToString()}");
			WriteLine($"z.ToString() = {z.ToString()}");
		} catch (Exception ex) {
			WriteLine("Falhou");
			WriteLine(ex);
		}
	}
}

//https://pt.stackoverflow.com/q/121950/101
