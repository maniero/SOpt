using System;
using System.ComponentModel;
					
public class Program {
	public static void Main() => Console.WriteLine(BBCodes.Bold.Wrap("StackOverflow"));
}

public enum BBCodes {
	[Description("b")]
	Bold = 1,
	[Description("i")]
	Italic = 2
}

public static class BBCodesExt {
	public static string Wrap(this BBCodes code, string contents) => $"[{code.ToStringDescription()}]{contents}[/{code.ToStringDescription()}]";
	public static string ToStringDescription(this BBCodes code) {
		var attributes = (DescriptionAttribute[])code.GetType().GetField(code.ToString()).GetCustomAttributes(typeof(DescriptionAttribute), false);
		return attributes.Length > 0 ? attributes[0].Description : "";
	}
}

//https://pt.stackoverflow.com/q/123841/101
