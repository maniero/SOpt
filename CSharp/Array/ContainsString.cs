using static System.Console;

public class Program {
	public static void Main() {
		var array = new string[1, 6] {{"texto", "", "", "", "", ""}};
    	if (array.ContainsInFirstCol("texto")) WriteLine("achou");        
	}
}

public static class ArrayExt {
	public static bool ContainsInFirstCol(this string[,] array, string search) {
		for (int row = array.GetLowerBound(0); row <= array.GetUpperBound(0); row++) {
			if (array[row, 0].Contains(search)) return true;
		}
		return false;
	}
}

//https://pt.stackoverflow.com/q/159207/101
