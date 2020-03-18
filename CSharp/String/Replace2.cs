using System;
using static System.Console;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Diagnostics;

public class Program {
	public static void Main() {
		const int times = 1000;
		string texto;
		var lista = "RUASANTA HELENA, 769  AP 51 BL H JD ALVORADA~ 17513322 ";
		var sw = new Stopwatch();
		WriteLine($"RegEx: {(Regex.Replace(lista, @"(\d+) ", "$1~ "))}");
		sw.Start();
		for (int i = 0; i < times; i++) texto = Regex.Replace(lista, @"(\d+) ", "$1~ ");
		sw.Stop();
		var timer1 = sw.ElapsedTicks;
		WriteLine($"SB:    {(MudaEndereco(lista))}");
		sw.Restart();
		for (int i = 0; i < times; i++) texto = MudaEndereco(lista);
		sw.Stop();
		var timer2 = sw.ElapsedTicks;
		WriteLine($"SB2:   {(MudaEndereco2(lista, (c) => char.IsDigit(c), (c) => char.IsWhiteSpace(c)))}");
		sw.Restart();
		for (int i = 0; i < times; i++) texto = MudaEndereco2(lista, (c) => char.IsDigit(c), (c) => char.IsWhiteSpace(c));
		sw.Stop();
		var timer3 = sw.ElapsedTicks;
		var factor = Min(timer1, timer2, timer3);
		WriteLine($"RegEx: {(double)timer1 / factor, 6:0.000} ({TimeSpan.FromTicks(timer1).ToString((@"ss\:fff"))}) {timer1 / times, 3} Ticks cada");
		WriteLine($"SB:    {(double)timer2 / factor, 6:0.000} ({TimeSpan.FromTicks(timer2).ToString((@"ss\:fff"))}) {timer2 / times, 3} Ticks cada");
		WriteLine($"SB2:   {(double)timer3 / factor, 6:0.000} ({TimeSpan.FromTicks(timer3).ToString((@"ss\:fff"))}) {timer3 / times, 3} Ticks cada");
    }
	public static string MudaEndereco(string texto, char adicao = '~') {
		var resultado = new StringBuilder(texto.Length * 2);
		var anterior = '\0';
		foreach (var caractere in texto) {
			if (Char.IsDigit(anterior) && Char.IsWhiteSpace(caractere)) resultado.Append(adicao);
			resultado.Append(caractere);
			anterior = caractere;
		}
		return resultado.ToString();
	}
	public static string MudaEndereco2(string texto, Func<char, bool> sequencia, Func<char, bool> terminador, char adicao = '~') {
		var resultado = new StringBuilder(texto.Length * 2);
		var anterior = '\0';
		foreach (var caractere in texto) {
			if (sequencia(anterior) && terminador(caractere)) resultado.Append(adicao);
			resultado.Append(caractere);
			anterior = caractere;
		}
		return resultado.ToString();
	}
	
	public static T Min<T>(params T[] numbers) => numbers.Min();
}

//https://pt.stackoverflow.com/q/135183/101
