using static System.Console;

public class Program {
	public static void Main() {
		var text = "text";
		ChangeText(text);
		WriteLine(text);
		ChangeText(ref text);
		WriteLine(text);
	}
	static void ChangeText(string text) { 
		text = "new text";
	}
	static void ChangeText(ref string text) { 
		text = "new text";
	}
}

//http://pt.stackoverflow.com/q/194151/101
