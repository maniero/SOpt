using static System.Console;
using System;

public class Program  {
	public static void Main() {
		var time = "00:97:54".Split(':');
		WriteLine(new TimeSpan(int.Parse(time[0]), int.Parse(time[1]), int.Parse(time[2])));
	}
}

//https://pt.stackoverflow.com/q/205961/101
