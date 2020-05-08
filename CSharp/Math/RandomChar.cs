using System;
using System.Text;
using static System.Console;

public class Program {
	public static Random Rand = new Random(DateTime.Now.Millisecond);
	public static string Text = "10";
	public static void Main() => Rodar();
    public static void Rodar() {
        if (!int.TryParse(Text, out var num)) return;
        var resultado = new StringBuilder(11);
        for (var i = 0; i < num; i++) {
			for (var j = 0; j < 11; j++) resultado.Append((char)(Rand.Next(1, 26) + 97));
			WriteLine(resultado);
			resultado.Clear();
		}
    }
}

//https://pt.stackoverflow.com/q/450593/101
