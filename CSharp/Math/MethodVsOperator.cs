using static System.Console;
using System;
					
public class Program {
	static Random r = new Random();
	static int x = r.Next(6, 11);
	static int y = r.Next(1, 6);
	public static void Main() {
		decimal a = x / y;
		WriteLine($"{x} / {y} = {a}");
		Teste();
	}
	public static void Teste() {
		decimal a = decimal.Divide(x, y);
		WriteLine($"{x} Divide {y} = {a}");
	}
}

//https://pt.stackoverflow.com/q/125476/101
