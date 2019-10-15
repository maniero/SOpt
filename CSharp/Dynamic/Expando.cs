using static System.Console;
using System.Dynamic;

public class Program {
    public static void Main() {
        dynamic obj = new ExpandoObject();
        obj.propriedade1 = "valor1";
        obj.propriedade2 = "valor2";
        WriteLine(obj.propriedade1);
        WriteLine(obj.propriedade2);
    }
}

//https://pt.stackoverflow.com/q/68085/101
