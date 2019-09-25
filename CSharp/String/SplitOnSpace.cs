using static System.Console;
using System.Linq;
using System.Diagnostics;
					
public class Program {
	public static void Main() {
		var texto = "João da Maquipe";
		var parte = texto.Substring(0, texto.IndexOf(' '));
		WriteLine(parte);
		var first = texto.Split(' ').FirstOrDefault();
		WriteLine(first);
		var tempo = new Stopwatch();
		for (var i = 0; i < 10000; i++) {
			parte = texto.Substring(0, texto.IndexOf(' '));
		}
		WriteLine(tempo.ElapsedTicks);
		tempo.Restart();
		for (var i = 0; i < 10000; i++) {
			first = texto.Split(' ').FirstOrDefault();
		}
		WriteLine(tempo.ElapsedTicks);
	}
}

//https://pt.stackoverflow.com/q/82070/101
