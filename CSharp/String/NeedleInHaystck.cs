using static System.Console;
using System.Linq;

public class Program {
	public static void Main() {
		string[] warnings = {
			"INQUIRY REQUEST",
			"ITEM ALREADY EXISTS",
			"ITEM NOT FOUND",
			"END OF FILE",
			};
		var status = " 18:46:24:97    INQUIRY REQUEST                                                 ";
		if (warnings.Any(warning => status.Contains(warning))) WriteLine("achou");
		else WriteLine("não achou");
	}
}

//https://pt.stackoverflow.com/q/445252/101
