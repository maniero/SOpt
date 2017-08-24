using static System.Console;
using System.Collections.Generic;

public class Program {
	public static void Main() {
		var ints = new List<int> { 1, 2, 3 };
		var lists = new List<List<int>> { new List<int> { 1, 2, 3 }, new List<int> { 4, 5, 6 } };
		foreach (var item in ints) {
//			item = 9;
		}
		foreach (var item in lists) {
			item[0] = 9;
		}
		foreach (var item in lists) {
//			item = new List<int> { 7, 8, 9 };
		}
		foreach (var lista in lists) {
			foreach (var item in lista) {
				WriteLine(item);
			}
		}
	}
}

//https://pt.stackoverflow.com/q/231849/101
