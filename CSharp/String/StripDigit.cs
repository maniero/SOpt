using static System.Console;
using System.Text;

public class Program {
	public static void Main() {
		WriteLine("123.456.789/ 0001-99X".Strip());
		WriteLine("(19)9-98/754?283 A".Strip());
	}
}

public static class StringExt {
    public static string Strip(this string str) {
        var sb = new StringBuilder(str.Length);
        foreach (var chr in str) if (char.IsDigit(chr)) sb.Append(chr);
        return sb.ToString();
    }
}

//https://pt.stackoverflow.com/q/290618/101
