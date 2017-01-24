using System;
using System.Globalization;
					
public class Program {
	public static void Main() {
		var mainStr = "José João";
		Console.WriteLine(mainStr.ContainsInsensitive("JOA"));
		Console.WriteLine(mainStr.ContainsInsensitive("jose"));
		Console.WriteLine(mainStr.ContainsInsensitive("josé"));
	}
}

namespace System {
	public static class StringExt {
		public static bool ContainsInsensitive(this string source, string search) {
			return (new CultureInfo("pt-BR").CompareInfo).IndexOf(source, search, CompareOptions.IgnoreCase | CompareOptions.IgnoreNonSpace) >= 0;
		}
	}
}

//http://pt.stackoverflow.com/q/179620/101
