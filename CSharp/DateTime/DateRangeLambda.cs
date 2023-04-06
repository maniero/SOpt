using System;

var inicio = new DateTime(2023, 04, 01);
var fim = new DateTime(2023, 04, 30);
DoDays(inicio, fim, (DateTime dia) => Console.WriteLine(dia));

static void DoDays(DateTime start, DateTime end, Action<DateTime> action) {
    for (var day = start; day <= end; day = day.AddDays(1)) action(day);
}

//https://pt.stackoverflow.com/q/580962/101
