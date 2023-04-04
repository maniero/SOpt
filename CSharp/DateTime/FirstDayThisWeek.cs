using System;
using static System.Console;

WriteLine(DateTime.Now.StartOfWeek(DayOfWeek.Monday));
WriteLine(DateTime.Now.StartOfWeek());

public static class DateTimeExtensions {
    public static DateTime StartOfWeek(this DateTime dt, DayOfWeek startOfWeek = DayOfWeek.Sunday) => dt.AddDays(-(7 + (dt.DayOfWeek - startOfWeek)) % 7).Date;
}

//https://pt.stackoverflow.com/q/580778/101
