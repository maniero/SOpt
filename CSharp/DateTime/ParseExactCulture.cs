using System;
using static System.Console;
using System.Globalization;
					
public class Program {
	public static void Main(){
		var data = "01/08/2016 9:00 PM";
		DateTime dataOut;
		if (DateTime.TryParseExact(data, "MM/dd/yyyy h:mm tt", CultureInfo.InvariantCulture, DateTimeStyles.None, out dataOut)) {
		    WriteLine(dataOut.ToString("MM/dd/yyyy HH:mm"));
		}
		data = "01/08/2016 9:00 AM";
		if (DateTime.TryParseExact(data, "MM/dd/yyyy h:mm tt", CultureInfo.InvariantCulture, DateTimeStyles.None, out dataOut)) {
		    WriteLine(dataOut.ToString("MM/dd/yyyy HH:mm"));
		}
	}
}

//https://pt.stackoverflow.com/q/150295/101
