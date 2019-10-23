using static System.Console;
using System;
					
public class Program {
	public static void Main() 	{
		WriteLine(AddBusinessDays(DateTime.Now, 8));
		WriteLine(AddBusinessDays(new DateTime(2015, 10, 26), 15));
	}

	public static DateTime AddBusinessDays(DateTime date, int days) {
		if (days < 0) throw new ArgumentException("days cannot be negative", "days");
		if (days == 0) return date;
		if (date.DayOfWeek == DayOfWeek.Saturday) {
			date = date.AddDays(2);
			days -= 1;
		} else if (date.DayOfWeek == DayOfWeek.Sunday) {
			date = date.AddDays(1);
			days -= 1;
		}
		date = date.AddDays(days / 5 * 7);
		int extraDays = days % 5;
		if ((int)date.DayOfWeek + extraDays > 5) extraDays += 2;
		return date.AddDays(extraDays);
	}
}

//https://pt.stackoverflow.com/q/94496/101
