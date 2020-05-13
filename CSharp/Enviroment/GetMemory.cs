using static System.Console;
using System.Diagnostics;

public class Program {
	public static void Main() {
		using var proc = Process.GetCurrentProcess();
		WriteLine(proc.PrivateMemorySize64);
		WriteLine(proc.WorkingSet64);
	}
}

//https://pt.stackoverflow.com/q/198632/101
