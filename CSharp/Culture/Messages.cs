using System;
using System.Threading;
using System.Globalization;
					
public class Program {
	public static void Main() {
		Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("pt-BR");
		Console.WriteLine(new NullReferenceException().Message);
	}
}

//https://pt.stackoverflow.com/q/78613/101
