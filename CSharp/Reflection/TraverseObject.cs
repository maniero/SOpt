using static System.Console;

public class Program {
    public static void Main() => Teste(new { param2 = 12345, otherParam = "huehuehue" });
    public static void Teste<T>(T param){
        foreach (var item in typeof(T).GetProperties()) WriteLine($"{item.Name} : {item.GetValue(param, null)}");
    }
}

//https://pt.stackoverflow.com/q/270821/101
