using static System.Console;

public class Program {
	public static void Main() {
		int[,] array = new int[10,10];
		for (int l = 0; l < 10; l++) {
			for (int c = 0; c < 10; c++) array[l, c] = c;
		}
		for (int l = 0; l < 10; l++) {
			for (int c = 0; c < 10; c++) Write($"{array[l, c]} ");
			WriteLine();
		}
		WriteLine();
		for (int l = 0; l < 10; l++) {
			for (int c = l; c < 10; c++) {
			    int temp = array[l, c];
			    array[l, c] = array[c, l];
			    array[c, l] = temp;
			}
		}
		for (int l = 0; l < 10; l++) {
			for (int c = 0; c < 10; c++) Write($"{array[l, c]} ");
			WriteLine();
		}
	}
}

//https://pt.stackoverflow.com/q/220469/101
