using static System.Console;
using static System.Convert;
using System.Numerics;
using System.Globalization;
					
public class Program {
	public static void Main() {
		var hex = "E365A931A000000";
		WriteLine(ToInt64(hex, 16));
		hex = "E365A931";
		WriteLine(ToInt32(hex, 16));
		hex = "E365A931A000000000";
		WriteLine(BigInteger.Parse(hex, NumberStyles.HexNumber));
	}
}

//https://pt.stackoverflow.com/q/52865/101
