using static System.Console;

public class Program {
	public static void Main() {
		var array2D = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
		WriteLine(array2D[0, 0]);
		WriteLine(array2D[2, 1]); //2 (linha) * 3 (total de colunas + 1 (coluna) = 7
		var array1D = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
		WriteLine(array1D[0]);
		WriteLine(array1D[7]);
		for (int i = 0; i < array2D.GetLength(0); i++) {
			for (int j = 0; j < array2D.GetLength(1); j++) Write($"{array2D[i, j]} ");
			WriteLine();
		}
		for (int i = 0; i < array1D.Length; i++) Write($"{array1D[i]} ");	}
}

//https://pt.stackoverflow.com/q/397146/101
