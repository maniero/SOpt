using static System.Console;

public class Exemplo {
	public static void Main() {
		UseParams(1, 2, 3, 4);
		UseParams(1);
		UseParams();
		UseParams(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
		UseParams2("lista", 1, 2, 3, 4);
	}
    public static void UseParams(params int[] list) {
        foreach (var item in list) Write(item + " ");
        WriteLine();
    }
    public static void UseParams2(string text, params int[] list) {
        Write(text + ": ");
        foreach (var item in list) Write(item + " ");
        WriteLine();
    }
}

//https://pt.stackoverflow.com/q/119086/101
