using static System.Console;
using System.Diagnostics;

public class Program {
    public static void Main() {
		var stopwatch = new Stopwatch();
		stopwatch.Start();
		Teste();
		stopwatch.Stop();
		WriteLine($"Tempo passado: {stopwatch.Elapsed}");
		stopwatch.Restart();
		for (var i = 0; i < 1000; i++) Teste();
		WriteLine($"Tempo passado: {stopwatch.ElapsedTicks}");
		stopwatch.Stop();
	}
	public static void Teste() => WriteLine("Fazendo algo aqui");
}

//https://pt.stackoverflow.com/q/89622/101
