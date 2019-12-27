using static System.Console;
using System;
					
public class Program {
	public static void Main() => WriteLine(DateTime.Now.ToTimestamp());
}

public static class DateTimeExt { 
	public static readonly DateTime TimeStampStart = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
	public static long ToTimestamp(this DateTime value) => (long)(value - TimeStampStart).TotalSeconds;
}

//https://pt.stackoverflow.com/q/124769/101
