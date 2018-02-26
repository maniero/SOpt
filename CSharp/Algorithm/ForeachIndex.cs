using static System.Console;
using System.Linq;

public class Program {
    public static void Main() {
        var lista = new[] { "abc", "def", "ghi" };
        foreach (var item in lista.Select((value, i) => (i, value ))) {
            WriteLine($"{item.i} => {item.value}");
        }
    }
}

//https://pt.stackoverflow.com/q/278924/101
