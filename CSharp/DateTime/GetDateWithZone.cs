using static System.Console;
using System;

public class Program {
	public static void Main() {
		WriteLine(PegaHoraBrasilia());
	}
	public static DateTime PegaHoraBrasilia() => TimeZoneInfo.ConvertTime(DateTime.Now, TimeZoneInfo.FindSystemTimeZoneById("E. South America Standard Time"));
}

//https://pt.stackoverflow.com/q/46488/101
