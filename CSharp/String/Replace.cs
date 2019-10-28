using static System.Console;
					
public class Program {
	public static void Main() {
	    var texto = "(99) 9999-9999";
		WriteLine(texto.Replace(new string[] {"(", ")", "-", " " }, ""));
	}
}

public static class StringExt {
    public static string Replace(this string str, string[] separators, string newValue) {
	    foreach (var chr in separators) str = str.Replace(chr, newValue);
		return str;
	}
}

//https://pt.stackoverflow.com/q/98332/101
