using static System.Console;
using System.IO;
using System.Linq;

public class Program {
	public static void Main() {
		var arquivos = Directory.EnumerateFiles(".", "*", SearchOption.AllDirectories).Select(Path.GetFileName);
		foreach (var item in arquivos) WriteLine(item);
	}
}

//https://pt.stackoverflow.com/q/89296/101
