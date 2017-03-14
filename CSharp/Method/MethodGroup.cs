using System;
using static System.Console;

public class Program {
	public static void Main() {
		var numero = 123;
		Func<string, string> func = numero.ToString;
		WriteLine(func("000000"));
		Func<string> func2 = numero.ToString;
		WriteLine(func2());
		Action<string> a = delegate(string txt) { WriteLine(txt); };
		Action<string> b = txt => WriteLine(txt);
		Action<string> c = WriteLine;
		a("abc");
		b("abc");
		c("abc");
	}
}

//http://pt.stackoverflow.com/q/189905/101
