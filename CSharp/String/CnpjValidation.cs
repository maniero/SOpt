using static System.Console;
using System;

(var ok, var digitos) = ValidarCnpj("12345678901234");
if (!ok) WriteLine($"Dígitos finais corretos seriam {digitos}");

static (bool, string) ValidarCnpj(string cnpj) {
	if (cnpj.Length < 14) return (false, "");
    Span<int> digitos = stackalloc int[14];
	for (int i = 0; i < 14; i++) if (char.IsDigit(cnpj[i])) digitos[i] = cnpj[i] - 48;
    int soma = 0, soma2 = 0;
	for (var i = 0; i < 4; i++) {
		soma += digitos[i] * (5 - i);
		soma2 += digitos[i] * (6 - i);
	}
	soma2 += digitos[4] * 2;
	for (var i = 4; i < 11; i++) {
		soma += digitos[i] * (13 - i);
		soma2 += digitos[i + 1] * (13 - i);
	}
	soma += digitos[11] * 2;
    var resto = soma % 11;
	var dv = digitos[12];
    digitos[12] = resto < 2 ? 0 : 11 - resto;
    soma2 += digitos[12] * 2;
	var ok = digitos[12] == dv;
    resto = soma2 % 11;
	dv = digitos[13];
	digitos[13] = resto < 2 ? 0 : 11 - resto;
    return (ok && digitos[13] == dv, string.Concat(digitos[12], digitos[13]));
}

//https://pt.stackoverflow.com/q/60577/101
