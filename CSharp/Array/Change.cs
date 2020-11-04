using static System.Console;
using System.Linq;
					
public class Program {
	public static void Main() {
		var optionArray = new string[] { "in the jungle ", " the mighty jungle", " the lion sleeps tonight " };
		var newArray = optionArray.Select(s => s.Trim()).ToArray();
		foreach (var item in newArray) {
			WriteLine($"|{item}|");
		}
		for (var i = 0; i < optionArray.Length; i++) {
			optionArray[i] = optionArray[i].Trim();
		}
		foreach (var item in optionArray) {
			WriteLine($"|{item}|");
		}
	}
}

//https://pt.stackoverflow.com/q/142740/101
