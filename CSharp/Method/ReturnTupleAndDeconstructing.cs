using System;

public class Program {
	public static void Main() {
		var (deuCerto, resultado) = "123".TryParseInt32();
		if (deuCerto) {
			Console.WriteLine(resultado);
		}
	}
}

namespace System {
	public static class StringExt {
		public static (bool ok, int result) TryParseInt32(this string text) {
			return (int.TryParse(text, out var result), result);
		}
	}
}

//http://pt.stackoverflow.com/q/195460/101
