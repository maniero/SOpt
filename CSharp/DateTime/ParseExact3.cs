using System;
using static System.Console;
using System.Globalization;
					
public class Program {
	public static void Main() {
		WriteLine(DateTime.ParseExact("03/16/2016 04:09:16.936", "MM/dd/yyyy HH:mm:ss.fff", CultureInfo.InvariantCulture));
		WriteLine(DateTime.Parse("03/16/2016 04:09:16.936", new CultureInfo("en-US")));
	}
}

//https://pt.stackoverflow.com/q/118450/101
