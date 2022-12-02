using static System.Console;
using System.Globalization;
					
var texto = "2,32";
var valor = decimal.Parse(texto, new CultureInfo("pt-BR"));
var formatado = valor.ToString("N2", new CultureInfo("en-US"));
WriteLine(formatado);

//https://pt.stackoverflow.com/q/252894/101
