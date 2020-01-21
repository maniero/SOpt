using static System.Console;
using System.Collections.Generic;
using System.Linq;

public class Program {
	public static void Main() {
		var lst = new List<string>{"123", "Teste 123 Teste", "ABC", "ABCDE123", "1 2 3" };
		var filter = lst.Where(s => s.Contains("123") || s.Contains("ABC")).Take(3).ToList();
		foreach (var item in filter) WriteLine(item);
	}
}

//https://pt.stackoverflow.com/q/134764/101
