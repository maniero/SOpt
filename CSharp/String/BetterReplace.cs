using static System.Console;
using System.Text;
using System.Linq;
					
public class Program {
	public static void Main() {
	    var texto = "(99) 9999-9999";
		WriteLine(texto.Replace("", '(', ')', '-', ' '));
	}
}

public static class StringExt {
	public static string Replace(this string str, string newValue, params char[] chars) {
		var sb = new StringBuilder();
		foreach (var chr in str) {
			if (!chars.Contains(chr)) sb.Append(chr);
			else sb.Append(newValue);
		}
		return sb.ToString();
	}
}

//https://pt.stackoverflow.com/q/98332/101
