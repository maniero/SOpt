using System;
using static System.Console;

public class Program {
	public static void Main() {
		WriteLine("123456789".Right(4));
	}
}

namespace System {
    public static class StringExtensions {
        public static string Right(this string texto, int length) => texto.Substring(texto.Length - length);
    }
}

//https://pt.stackoverflow.com/q/349829/101
