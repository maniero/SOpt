using static System.Console;
using System;

(var ok, var digitos) = ValidarCnpj("12345678901234");
if (!ok) WriteLine($"Dígitos finais corretos seriam {digitos}");
(ok, digitos) = ValidarCnpj("12.345.678.9012-34");
if (!ok) WriteLine($"Dígitos finais corretos seriam {digitos}");

static (bool, string) ValidarCnpj(string cnpj) {
    if (cnpj.Length < 14) return (false, "");
    Span<int> digitos = stackalloc int[14];
    for (int i = 0, j = 0; i < 14; j++) if (char.IsDigit(cnpj[j])) digitos[i++] = cnpj[j] - 48;
    int soma = 0, soma2 = 0;
    soma += digitos[0] * 5;
    soma2 += digitos[0] * 6;
    soma += digitos[1] * 4;
    soma2 += digitos[1] * 5;
    soma += digitos[2] * 3;
    soma2 += digitos[2] * 4;
    soma += digitos[3] * 2;
    soma2 += digitos[3] * 3;
    soma += digitos[4] * 9;
    soma2 += digitos[4] * 2;
    soma += digitos[5] * 8;
    soma2 += digitos[5] * 9;
    soma += digitos[6] * 7;
    soma2 += digitos[6] * 8;
    soma += digitos[7] * 6;
    soma2 += digitos[7] * 7;
    soma += digitos[8] * 5;
    soma2 += digitos[8] * 6;
    soma += digitos[9] * 4;
    soma2 += digitos[9] * 5;
    soma += digitos[10] * 3;
    soma2 += digitos[10] * 4;
    soma += digitos[11] * 2;
    soma2 += digitos[11] * 3;
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
