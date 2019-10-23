using static System.Console;
using System.Diagnostics;
					
public class Program {
	public static void Main() {
		var x = "";
		var sw = new Stopwatch();
		sw.Start();
		for (var i = 0; i < 10000; i++) x = string.Format("teste de string formatada com resultado: {0}", i + 5);
		sw.Stop();
		WriteLine(sw.ElapsedTicks);
		sw.Restart();
		for (var i = 0; i < 10000; i++) x = $"teste de string formatada com resultado: {i + 5}";
		sw.Stop();
		WriteLine(sw.ElapsedTicks);
	}
}

//https://pt.stackoverflow.com/q/93207/101
