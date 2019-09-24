using System;
using static System.Console;
					
public class Program {
	public static void Main() {
		var data = new DateTime(2015, 8, 15);
		WriteLine(FirstDayPreviousMonth(data));
		WriteLine(LastDayPreviousMonth(data));
		data = new DateTime(2015, 3, 15);
		WriteLine(FirstDayPreviousMonth(data));
		WriteLine(LastDayPreviousMonth(data));
		data = new DateTime(2016, 3, 15);
		WriteLine(FirstDayPreviousMonth(data));
		WriteLine(LastDayPreviousMonth(data));
	}
	public static DateTime FirstDayPreviousMonth(DateTime date) {
	    var mesAnterior = date.AddMonths(-1);
		return new DateTime(mesAnterior.Year, mesAnterior.Month, 1); 
	}
	public static DateTime LastDayPreviousMonth(DateTime date) {
	    var mesAnterior = date.AddMonths(-1);
		return new DateTime(mesAnterior.Year, mesAnterior.Month, DateTime.DaysInMonth(mesAnterior.Year, mesAnterior.Month));
	}
}

//https://pt.stackoverflow.com/q/80330/101
