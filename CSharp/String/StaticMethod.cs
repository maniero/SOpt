using System;
using static System.Console;
					
public class Program {
	public static void Main() {
		WriteLine("123".Concatenate("456"));
		string.Concat(null, "xxx");
	}
}

namespace System { //isto estaria provavelmente em outro arquivo ou até outro projeto, talvez junto com outros métodos de extensão.
	public static class StringExt {
		public static string Concatenate(this string str1, string str2)	{
			return string.Concat(str1, str2);
		}
	}
}

//http://pt.stackoverflow.com/q/189606/101
