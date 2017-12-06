public class Program {
    public static void Main() {
        var nome = new Name(new char[32]);
    }
}

public struct Name {
    public Name(char[] nome) => Nome = nome;
    public char[] Nome;
}

//https://pt.stackoverflow.com/q/258641/101
