using static System.Console;
using System;
using System.Linq;

WriteLine(GerarCpf(Uf.SP));
WriteLine(GerarCpf());

static string GerarCpf(Uf uf = Uf.NA) {
	Random random = new();
	int[] digitos = new int[11];
	int soma = 0, soma2 = 0;
	do {
		for (var i = 0; i < 8; i++) {
			digitos[i] = random.Next(10);
			soma += digitos[i] * (10 - i);
			soma2 += digitos[i] * (11 - i);
		}
		digitos[8] = uf == Uf.NA ? random.Next(10) : (int)uf;
		soma += digitos[8] * 2;
		soma2 += digitos[8] * 3;
	} while (Repetidos(digitos));
	var resto = soma % 11;
	digitos[9] = resto < 2 ? 0 : 11 - resto;
	soma2 += digitos[9] * 2;
	resto = soma2 % 11;
	digitos[10] = resto < 2 ? 0 : 11 - resto;
	return string.Join("", digitos.Select(p => p.ToString()).ToArray());
}

static bool Repetidos(int[] digitos) {
	var val = digitos[0];
	return digitos.Take(9).All(x => x == val);
}

enum Uf {
	AC = 2,	AL = 4,	AP = 2,	AM = 2,	BA = 5,	CE = 3,	DF = 1,	ES = 7,	GO = 1,	MA = 3,	MT = 1,	MS = 1,	MG = 6,	PA = 2,	PB = 4,	PR = 9,	PE = 4,	PI = 3,	RJ = 7,	RN = 4,	RS = 0,	RO = 2,	RR = 2,	SC = 9,	SP = 8,	SE = 5,	TO = 1,	NA = -1
}

//https://pt.stackoverflow.com/q/33669/101
