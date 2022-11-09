using static System.Console;
using System.Text;
					
var texto = "Você chegou em 1º lugar, Parabéns!";
StringBuilder novo = new(texto.Length);
foreach (var c in texto) if ("1234567890abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZáéíóúàèìòùâêîôûãõçÁÉÍÓÚÀÈÌÒÙÂÊÎÔÛÃÕÇ ".IndexOf(c) >= 0) novo.Append(c);
WriteLine(novo);

//https://pt.stackoverflow.com/q/25924/101
