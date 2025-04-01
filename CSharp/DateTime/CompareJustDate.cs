using System;
DateTime date = new(89, 3, 12, 12, 43, 34);
DateTime date2 = new(89, 3, 12, 11, 22, 12);
DateOnly d1 = new(date.Year, date.Month , date.Day);
DateOnly d2 = new(date2.Year, date2.Month , date2.Day);
Console.WriteLine(date == date2);
Console.WriteLine(d1 == d2);

//https://stackoverflow.com/a/79547454/221800 
