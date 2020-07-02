using System;
using static System.Console;
using System.Diagnostics;
using  System.Text.RegularExpressions;
using System.Linq;
using System.Text;

public class Program {
	public static void Main() {
		const int total = 1_000_000;
		var cpf = "111.222.333-44";
		var formatado = "";
		var sw = Stopwatch.StartNew();
		for (var i = 0; i < total; i++) {
			formatado = cpf.Substring(0, 3) + cpf.Substring(4, 3) + cpf.Substring(8, 3) + cpf.Substring(12, 2);
		}
		sw.Stop();
		WriteLine(sw.ElapsedMilliseconds);
		sw.Restart();
		for (var i = 0; i < total; i++) {
			formatado = string.Concat(cpf.AsSpan(0, 3), cpf.AsSpan(4, 3), cpf.AsSpan(8, 3), cpf.AsSpan(12, 2));
		}
		sw.Stop();
		WriteLine(sw.ElapsedMilliseconds);
		sw.Restart();
		for (var i = 0; i < total; i++) {
			formatado = cpf[0..3] + cpf[4..7] + cpf[8..11] + cpf[12..14];
		}
		sw.Stop();
		WriteLine(sw.ElapsedMilliseconds);
		sw.Restart();
		for (var i = 0; i < total; i++) {
			var sb = new StringBuilder(cpf.Length);
			foreach (var letra in cpf) if (Char.IsDigit(letra)) sb.Append(letra);
			formatado = sb.ToString();
		}
		sw.Stop();
		WriteLine(sw.ElapsedMilliseconds);
		sw.Restart();
		for (var i = 0; i < total; i++) {
			formatado = string.Join("", cpf.ToCharArray().Where(Char.IsDigit));
		}
		sw.Stop();
		WriteLine(sw.ElapsedMilliseconds);
		sw.Restart();
		for (var i = 0; i < total; i++) {
			formatado = String.Join("", Regex.Split(cpf, @"[^\d]"));
		}
		sw.Stop();
		WriteLine(sw.ElapsedMilliseconds);
		sw.Restart();
		for (var i = 0; i < total; i++) {
			Regex r = new Regex(@"\d+");            
			var result = "";
			foreach (Match m in r.Matches(cpf))	result += m.Value;
			formatado = result;
		}
		sw.Stop();
		WriteLine(sw.ElapsedMilliseconds);
	}
}

//https://pt.stackoverflow.com/q/25469/101
