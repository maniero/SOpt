using static System.Console;

public class Program {
    public static void Main() {
        WriteLine(FormataRG("12345678x"));
        WriteLine(FormataRG("123456789"));
    }
    public static string FormataRG(string texto) => texto.Substring(0, 2) + "." + texto.Substring(2, 3) + "." + texto.Substring(5, 3) + "-" + texto.Substring(8, 1).ToUpper();
}

//https://pt.stackoverflow.com/q/55017/101
