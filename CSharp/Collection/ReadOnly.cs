using System;
using System.Collections.ObjectModel;
					
public class Program {
	public static void AlterarArray(ReadOnlyCollection<int> input) {
		input[1] = 10;
	}
	
	public static void Main() {
		int[] teste = new int[] {1, 2, 3, 4, 5};
		AlterarArray(Array.AsReadOnly(teste));
		Console.WriteLine(string.Join('\n', teste));
	}
}

//https://pt.stackoverflow.com/q/542007/101
