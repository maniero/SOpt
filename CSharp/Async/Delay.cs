using static System.Console;
using System.Threading;
using System.Threading.Tasks;
using System.Diagnostics;

public class Program {
    public static void Main(string[] args) {
        Task wait = ComDelay();
		WriteLine("O Main está executando algo após o Delay");
        wait.Wait();
        ComSleep();
		WriteLine("O Main está executando algo após o Sleep");
    }

    static async Task ComDelay() {
		var sw = new Stopwatch();
		sw.Start();
        WriteLine("Início Delay");
        await Task.Delay(2000);
        WriteLine("Demorou {0}ms", sw.ElapsedMilliseconds);
        WriteLine("Fim Delay");
    }

    static void ComSleep() {
		var sw = new Stopwatch();
		sw.Start();
        WriteLine("Início Sleep");
        Thread.Sleep(2000);
        WriteLine("Demorou {0}ms", sw.ElapsedMilliseconds);
        WriteLine("Fim Sleep");
    }
}

//https://pt.stackoverflow.com/q/86014/101
