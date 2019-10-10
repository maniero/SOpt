using System;
using static System.Console;
					
public class Program {
	public static void Main() {
		var minhaData = DateTime.UtcNow;
		WriteLine($"Hora universal {minhaData.ToLocalTime()}");
		var fuso = TimeZoneInfo.FindSystemTimeZoneById("E. South America Standard Time");
		var diferenca = new DateTimeOffset(minhaData, TimeSpan.Zero);
		WriteLine($"Hora local {diferenca.ToOffset(fuso.GetUtcOffset(diferenca))}");
		WriteLine($"Diferença {fuso.GetUtcOffset(diferenca)}");
	}
}

//https://pt.stackoverflow.com/q/88366/101
