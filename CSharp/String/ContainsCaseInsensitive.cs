using System;
					
public class Program {
	public static void Main() {
		var mainStr = "Joaquim Pedro Soares";
		Console.WriteLine(mainStr.Contains("JOA", StringComparison.OrdinalIgnoreCase));
		Console.WriteLine(mainStr.Contains("Quim", StringComparison.OrdinalIgnoreCase));
		Console.WriteLine(mainStr.Contains("PEDRO", StringComparison.OrdinalIgnoreCase));
		Console.WriteLine(mainStr.Contains("PeDro", StringComparison.OrdinalIgnoreCase));
	}
}

namespace System {
	public static class StringExt {
		public static bool Contains(this string source, string search, StringComparison comparison) {
			return source.IndexOf(search, comparison) >= 0;
		}
	}
}

//http://pt.stackoverflow.com/q/179568/101
