using System;
using static System.Console;

public class Program {
	public static void Main() {
		WriteLine("HelloWorld".ToCamelCase());
	}
}

namespace System {
    public static class StringExt {
        public static string ToCamelCase(this string text) => char.ToLower(text[0]) + text.Substring(1);
    }
}

//https://pt.stackoverflow.com/q/41944/101
