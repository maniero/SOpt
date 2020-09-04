using System;
using static System.Console;
using static System.Math;
using System.Diagnostics;
					
public class Program {
	public static void Main() {
		var tempo = new Stopwatch();
		WriteLine("Decimal");
		tempo.Start();
		for (var valor = -10000M; valor <= 10000M; valor += 0.05M) valor.RoundMidPoint();
        tempo.Stop();
        WriteLine("Arredondando em ms: {0}", tempo.ElapsedMilliseconds);
		WriteLine("Double");
		tempo.Start();
		for (var valor = -10000.0; valor <= 10000.0; valor += 0.05) valor.RoundMidPoint();
        tempo.Stop();
        WriteLine("Arredondando em ms: {0}", tempo.ElapsedMilliseconds);
		WriteLine("Decimal Alternativo");
		tempo.Start();
		for (var valor = -10000M; valor <= 10000M; valor += 0.05M) valor.RoundMidPointAlt();
        tempo.Stop();
        WriteLine("Arredondando em ms: {0}", tempo.ElapsedMilliseconds);
		WriteLine("Double Alternativo");
		tempo.Start();
		for (var valor = -10000.0; valor <= 10000.0; valor += 0.05) valor.RoundMidPointAlt();
        tempo.Stop();
        WriteLine("Arredondando em ms: {0}", tempo.ElapsedMilliseconds);
	}
}

public static class RoundUtil {
	public static Decimal RoundMidPoint(this Decimal value) => Sign(value) * Ceiling(Abs(value) * 2) / 2;
	
	public static double RoundMidPoint(this double value) => Sign(value) * Ceiling(Abs(value) * 2) / 2;
	
	public static Decimal RoundMidPointAlt(this Decimal value) {
		int intPart = (int)value;
		decimal decimalPart = value - intPart;
		if (0 < decimalPart && decimalPart <= 0.5M) return intPart + 0.5M;
		else if (0.5M < decimalPart) return intPart + 1;
		else return intPart;
	}

	public static double RoundMidPointAlt(this double value) {
		int intPart = (int)value;
		double decimalPart = value - intPart;
		if (0 < decimalPart && decimalPart <= 0.5) return intPart + 0.5;
		else if (0.5 < decimalPart) return intPart + 1;
		else return intPart;
	}
}

//http://pt.stackoverflow.com/q/16185/101
