using static System.Console;
using static System.Math;
					
public class Program {
	public static void Main() {
		for (int i = 0; i < 20; i++) WriteLine($"{Fib(i)}, {FibIte(i)}, {FibRec(i)}");
	}
	static int Fib(int n) {
		double sqrt5 = Sqrt(5);
		double p1 = (1 + sqrt5) / 2;
		double p2 = -1 * (p1 - 1);
		return (int)((Pow(p1, n) - Pow(p2, n)) / sqrt5);
	}
	static int FibIte(int n) {
		int a = 0;
		int b = 1;
		for (int i = 0; i < n; i++) {
			int temp = a;
			a = b;
			b = temp + b;
		}
		return a;
	}
	static int FibRec(int n) => n < 2 ? n : FibRec(n - 1) + FibRec(n - 2);
}

//https://pt.stackoverflow.com/q/54456/101
