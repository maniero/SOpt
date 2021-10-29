using System;
using System.Globalization;
using static System.Console;
					
public class Program {
	public static void Main() {
		WriteLine(DateTime.Now.ToString(new CultureInfo("pt-BR", false).DateTimeFormat.ShortDatePattern));
		WriteLine(DateTime.Now.ToString(CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern));
	}
}

//https://pt.stackoverflow.com/q/121440/101
