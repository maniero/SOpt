using static System.Console;
using System.IO;
using System.Reflection;

public class Program {
	public static void Main() {
		WriteLine(Path.Combine(Directory.GetCurrentDirectory(), @"EmailTemplate/email.html"));
		WriteLine(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"EmailTemplate/email.html"));
	}
}

//https://pt.stackoverflow.com/q/54119/101
