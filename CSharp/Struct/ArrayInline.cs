public class Program {
    public static void Main() {
        var nome = new Name();
    }
}

public struct Name {
    private bool inicializado;
    private char[] nome;
    public char[] Nome { get {
        if (!inicializado) {
            nome = new char[32]; 
            inicializado = true;
        }
        return nome;
	}}
}

//https://pt.stackoverflow.com/q/258641/101
