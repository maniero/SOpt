using static System.Console;
using static System.Convert;

public class Program {
	public static void Main() {
		var x = 15.7M;
		WriteLine(ToUInt16(x));
		WriteLine((ushort)x);
	}
}

//https://pt.stackoverflow.com/q/273505/101
