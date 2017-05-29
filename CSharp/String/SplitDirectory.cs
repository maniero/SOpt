using static System.Console;
using System;

public class Program {
	public static void Main() {
		var dir = @"C:\ByMe\SOLUTIONS\Dictation1\Database\Updates\2017\2017_04\";
		var partes = dir.Split(new string[] { @"\Updates\" }, StringSplitOptions.None);
		WriteLine(partes[1]);
	}
}

//https://pt.stackoverflow.com/q/208381/101
