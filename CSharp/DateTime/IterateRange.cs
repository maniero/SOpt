using System;
					
var inicio = new DateTime(2023, 04, 01);
var fim = new DateTime(2023, 04, 30);
for (var dia = inicio; dia <= fim; dia = dia.AddDays(1)) Console.WriteLine(dia);

//https://pt.stackoverflow.com/q/580962/101
