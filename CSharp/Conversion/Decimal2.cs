using static System.Console;
using static System.Math;
using static System.Convert;
using static System.Globalization.NumberStyles;
using System.Globalization;

var x = 1.41293;
WriteLine(x.ToString("N3"));
WriteLine(Round(x, 3));
WriteLine(Round(ToDecimal(x), 3));
if (!decimal.TryParse("1,41293", Number, new CultureInfo("pt-BR"), out var numero)) return;
WriteLine(Round(numero, 3));

//https://pt.stackoverflow.com/q/243124/101
