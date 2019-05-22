using static System.Console;

public class Program {
	public static void Main() {
		foreach (var item in Maior1(2, 3, 1)) WriteLine(item);
		WriteLine();
		foreach (var item in Maior1(1, 2, 3)) WriteLine(item);
		WriteLine();
		foreach (var item in Maior1(3, 2, 1)) WriteLine(item);
		WriteLine();
		foreach (var item in Maior1(1, 3, 2)) WriteLine(item);
		WriteLine();
		foreach (var item in Maior1(2, 1, 3)) WriteLine(item);
		WriteLine();
		foreach (var item in Maior1(3, 1, 2)) WriteLine(item);
	}
	public static int[] Maior1(int v1, int v2, int v3) {
		var array = new int[3];
		if (v1 > v2 && v1 > v3) {
			array[0] = v1;
			if (v2 > v3) {
				array[1] = v2;
				array[2] = v3;
			} else {
				array[1] = v3;
				array[2] = v2;
			}
		} else if (v2 > v1 && v2 > v3) {
			array[0] = v2;
			if (v1 > v3) {
				array[1] = v1;
				array[2] = v3;
			} else {
				array[1] = v3;
				array[2] = v1;
			}
		} else {
			array[0] = v3;
			if (v1 > v2) {
				array[1] = v1;
				array[2] = v2;
			} else {
				array[1] = v2;
				array[2] = v1;
			}
		}
		return array;
	}
}

//https://pt.stackoverflow.com/q/374556/101
