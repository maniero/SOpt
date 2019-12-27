using System;
					
public class Program {
	public static void Main() {
		var codigo = new BBCodes(BBCodes.Bold);
		Console.WriteLine(codigo.Wrap("StackOverflow"));
	}
}

public sealed class BBCodes {
	public static readonly string Bold = "b";
	public static readonly string Italic = "i";
	//...
	
	private string code;
	
	public BBCodes(string code) => this.code = code;
	
	public string Wrap(string contents) => $"[{code}]{contents}[/{code}]";
}

//https://pt.stackoverflow.com/q/123841/101
