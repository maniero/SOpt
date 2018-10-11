using System;
using static System.Console;

public class Program {
	public static void Main() {
		Write($"|{("Hello World".PadBoth(42))}|");
	}
}

namespace System {
	public static class StringExt {
		public static string PadBoth(this string str, int length, char character = ' ') => str.PadLeft((length - str.Length) / 2 + str.Length, character).PadRight(length, character);
	}
}

//https://pt.stackoverflow.com/q/41755/101
