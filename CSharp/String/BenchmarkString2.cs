using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Attributes;

[MemoryDiagnoser]
public class Program {
	public string cpf = "111.222.333-44";
	public static void Main(string[] args) => BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
	[Benchmark]
	public string Substring() => cpf.Substring(0, 3) + cpf.Substring(4, 3) + cpf.Substring(8, 3) + cpf.Substring(12, 2);
	[Benchmark]
	public string Span() => string.Concat(cpf.AsSpan(0, 3), cpf.AsSpan(4, 3), cpf.AsSpan(8, 3), cpf.AsSpan(12, 2));
	[Benchmark]
	public string Range() => cpf[0..3] + cpf[4..7] + cpf[8..11] + cpf[12..14];
	[Benchmark]
	public string Foreach() {
		var sb = new StringBuilder(cpf.Length);
		foreach (var letra in cpf) if (Char.IsDigit(letra)) sb.Append(letra);
		return sb.ToString();
	}
	[Benchmark]
	public string Linq() => string.Join("", cpf.ToCharArray().Where(Char.IsDigit));
	[Benchmark]
	public string RegexSplit() => String.Join("", Regex.Split(cpf, @"[^\d]"));
	[Benchmark]
	public string RegexReplace() => Regex.Replace(cpf, @"[^\d]", "");
	[Benchmark]
	public string RegexMatches() {
		Regex r = new Regex(@"\d+");
		var result = "";
		foreach (Match m in r.Matches(cpf)) result += m.Value;
		return result;
	}
	[Benchmark]
	public string RegexMatchesG() {
		Regex r = new Regex(@"\G");
		var result = "";
		foreach (Match m in r.Matches(cpf)) result += m.Value;
		return result;
	}
}

//https://pt.stackoverflow.com/q/25469/101
