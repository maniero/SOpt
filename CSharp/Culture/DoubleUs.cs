using static System.Console;
using System.Globalization;
					
public class Program {
	public static void Main() {
		WriteLine(double.Parse("-8.709006", CultureInfo.InvariantCulture).ToString(new CultureInfo("en-US", true)));
	}
}

//https://pt.stackoverflow.com/q/52015/101
