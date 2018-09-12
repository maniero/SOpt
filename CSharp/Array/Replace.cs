using static System.Console;
using static System.Diagnostics.Contracts.Contract;

public class Program {
	public static void Main() {
		foreach (var item in ReplaceRange(new int[] {0, 1, 2, 3, 4}, new int[] {5, 6, 7, 8, 9}, 2)) WriteLine(item);
	}
	public static T[] ReplaceRange<T>(T[] source, T[] destination, int start) {
		Requires(start >= 0, "O índice de início não pode ser menor que zero");
		Requires(start < source.Length, "O índice de início não pode ser maior que o fim do array");
		Requires(destination.Length >= source.Length - start, "O índice de início não pode ser maior que o que cabe");
		for (int i = start, j = 0; i < source.Length; i++, j++) destination[i] = source[j];
		return destination;
	}
}

//https://pt.stackoverflow.com/q/314158/101
