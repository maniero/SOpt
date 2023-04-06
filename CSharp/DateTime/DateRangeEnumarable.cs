using System;
using System.Collections.Generic;

var inicio = new DateTime(2023, 04, 01);
var fim = new DateTime(2023, 04, 30);
foreach (var dia in GetDays(inicio, fim)) Console.WriteLine(dia);

static IEnumerable<DateTime> GetDays(DateTime start, DateTime end) {
    for (var day = start; day <= end; day = day.AddDays(1)) yield return day;
}

//https://pt.stackoverflow.com/q/580962/101
