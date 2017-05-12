using System;
using System.Reflection;

public class Program {
    public static void Main(string[] args) {
		var pessoa = new Pessoa { id = 1, Nome = "Nicola Bogar Uccio", DataNascimento = new DateTime(1988, 08, 24) };
		PropertyInfo[] properties = Entities<Pessoa>.GetPropertiesComoEUQuero();
    }
}

public class Pessoa {
    public int id { get; set; }
    public string Nome { get; set; }
    public DateTime DataNascimento { get; set; }
}

public static class Entities<TEntidade> where TEntidade : class {
    public static PropertyInfo[] GetPropertiesComoEUQuero() {         
        return typeof(TEntidade).GetProperties();
    }
}

//https://pt.stackoverflow.com/q/203917/101
