using static System.Console;
using System.Collections.Generic;
using System.Linq;
					
public class Program {
	public static void Main() {
		var list = new List<int> { 1, 2, 3, 4, 5 };
		foreach (var pair in list.Select((x, i) => new {Index = i, Value = x})) WriteLine($"{pair.Index}: {pair.Value}");
	}
}

//https://pt.stackoverflow.com/q/151272/101
