using static System.Console;

public class Exercicio3 {
    public Exercicio3() => WriteLine("a");
    public Exercicio3(string pa) => WriteLine(pa + "\nh");
}
public class ClasseMae : Exercicio3 {
    public ClasseMae() => WriteLine("c");
    public ClasseMae(string pa) : base(pa) => WriteLine(pa + "\nd");
}
public class Program {
    public static void Main() {
        Exercicio3 exercicio = new("e");
        ClasseMae mae = new("b");
    }
}

//https://pt.stackoverflow.com/q/529766/101
