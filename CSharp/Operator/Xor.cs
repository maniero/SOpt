using static System.Console;
					
public class Program {
	public static void Main() {
		var calculoChave = 0;
		foreach (var c in new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9}) calculoChave ^= c;
		WriteLine(calculoChave);
	}
}

//https://pt.stackoverflow.com/q/48414/101
