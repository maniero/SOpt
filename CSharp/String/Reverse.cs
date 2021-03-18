using static System.Console;
using System.Text;

public class Program {
	public static void Main() {
        WriteLine(" Digite a Palavra");
        var s = ReadLine();
		var revs = new StringBuilder(s.Length);
        for (int i = s.Length - 1; i >= 0; i--) revs.Append(s.Substring(i, 1));
        WriteLine(revs);
	}
}

//https://pt.stackoverflow.com/q/498676/101
