using static System.Console;
using System.IO;
using System.Linq;

public class Program {
	public static void Main() => foreach (var item in Directory.EnumerateFiles(".", "*", SearchOption.AllDirectories).Select(Path.GetFileName);) WriteLine(item);
}

//https://pt.stackoverflow.com/q/89296/101
