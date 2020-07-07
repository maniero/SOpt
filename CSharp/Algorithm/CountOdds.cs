using static System.Console;
using static System.Math;

public class Program {
	public static void Main() {
		if (!int.TryParse(ReadLine(), out var x)) return;
		if (!int.TryParse(ReadLine(), out var y)) return;
		WriteLine((Abs(x - y) + 1) / 2);
	}
}

//https://pt.quora.com/Crie-um-algoritmo-que-receba-dois-n%C3%BAmeros-inteiros-e-determine-quantos-n%C3%BAmeros-%C3%ADmpares-existem-entre-eles-Exemplo-entre-5-e-16-h%C3%A1-6-%C3%ADmpares-5-7-9-11-13-15
