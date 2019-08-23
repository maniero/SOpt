using static System.Console;
using System.Reflection;

public class Program {
	public static void Main(string[] args) {
        var objGeneric = new Generica();
        objGeneric.Pessoa.Nome = "PAULO TADEU CHAGAS";
        objGeneric.Pessoa.Idade = 25;
        Teste(objGeneric.Pessoa);
    }
    static void Teste<T>(T xpto) {
        var tipo = xpto.GetType();
        PropertyInfo[] propt = tipo.GetProperties();
        foreach (var prop in tipo.GetProperties()) {
            WriteLine($"Nome: {prop.Name}");
            WriteLine($"Valor: {prop.GetValue(xpto, null)}");
        }
    }
}

public class Generica {
    public Pessoa Pessoa { get; set; }
	public Generica() => this.Pessoa = new Pessoa();
}

public class Pessoa {
    public string Nome { get; set; }
    public int Idade { get; set; }
}

//https://pt.stackoverflow.com/q/405090/101
