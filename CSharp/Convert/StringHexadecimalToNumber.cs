using static System.Console;
using System.Globalization;
					
public class Program {
	public static void Main() {
		WriteLine($"{int.Parse("7302", NumberStyles.HexNumber):X}");
		WriteLine($"{int.Parse("1A3B", NumberStyles.HexNumber):X}");
	}
}

//http://pt.stackoverflow.com/q/181044/101
