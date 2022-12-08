using System;
using static System.Console;

var soma = 0;
foreach (var elemento in Enum.GetValues(typeof(TrianguloLetra))) soma += (int)elemento;
WriteLine(soma);

public enum TrianguloLetra {
	a = 1, b, c, d,  e, f, g, h, i, j, k, l, m, n, o, p, q, r, s, t, u, v, w, x, y, z
}

//https://pt.stackoverflow.com/q/72986/101
