using System;
using static System.Console;

public class Program {
	public static void Main() => WriteLine((new DateTime(2017, 09, 10, 11, 45, 00).Date - new DateTime(2017, 09, 09, 11, 45, 20).Date).TotalDays);
}

//https://pt.stackoverflow.com/q/236093/101
