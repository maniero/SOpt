using static System.Console;
using System;
					
WriteLine(FormataTelefone("49988070405"));
WriteLine(FormataTelefone("4988070405"));

static string FormataTelefone(string number) {
	if (number.Length != 11 && number.Length != 10) throw new ArgumentException($"Tamanho da string {nameof(number)} deve ser 10 ou 11");
	ReadOnlySpan<char> span = stackalloc char[number.Length];
	span = number.AsSpan();
	var offset = 11 - number.Length;
	return $"({span[0..2]}) {span[2..(7 - offset)]}-{span[(7 - offset)..]}";
}

//https://pt.stackoverflow.com/q/283609/101
