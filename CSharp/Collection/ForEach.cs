using static System.Console;
using System.Collections.Generic;
public class C {
    public static void Main() {
        int[] array = new int[]{1, 2, 3, 4, 5, 6};
        foreach (int item in array) {
            WriteLine(item);
        }
        var lista = new List<int>{1, 2, 3, 4, 5, 6};
        foreach (int item in lista) {
            WriteLine(item);
        }
        var texto = "123456";
        foreach (char item in texto) {
            WriteLine(item);
        }
    }
}

//http://pt.stackoverflow.com/q/188067/101
