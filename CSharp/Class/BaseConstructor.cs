using static System.Console;

public static class Program {
    public static void Main(string[] args) {
        var gato = new Gato("Dener");
        WriteLine(gato.Nome);            
    }
}

public abstract class Animal {
    public string Nome { get; private set; }
    public Animal(string nome) => Nome = nome;
}

public class Gato : Animal {
    public Gato(string nome) : base(nome) {}
}

//https://pt.stackoverflow.com/q/332980/101
