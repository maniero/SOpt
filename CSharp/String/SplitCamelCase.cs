using static System.Console;
using System.Text;

public static class Program {
	public static void Main() {
		WriteLine("CamelCase".SplitCamelCase());
		WriteLine("Ca".SplitCamelCase());
		WriteLine("aC".SplitCamelCase());
		WriteLine("CC".SplitCamelCase());
		WriteLine("C".SplitCamelCase());
		WriteLine("CamelCaseC".SplitCamelCase());
		WriteLine("".SplitCamelCase());
		WriteLine("pascalCase".SplitCamelCase());
	}
	public static string SplitCamelCase(this string text, char separator = '-') {
		if (string.IsNullOrEmpty(text) || text.Length < 2) return text;
		var sb = new StringBuilder(text.Length + text.Length / 3);
		for (var i = 0; i < text.Length; i++) {
			if (char.IsUpper(text[i]) && i > 0) sb.Append(separator);
			sb.Append(text[i]);
			
		}
		return sb.ToString();
	}
}

//https://pt.stackoverflow.com/q/278619/101
