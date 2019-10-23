using System.Collections.Generic;

public class Program {
    public static void Main() {   
        var pessoas = new List<Pessoa>() {
			new Pessoa() {Nome = "José" , Sexo = "M"},
        	new Pessoa() {Nome = "Pedro", Sexo = "M"},
        	new Pessoa() {Nome = "João" , Sexo = "M"},
       		new Pessoa() {Nome = "Maria", Sexo = "F"}
		};
        bool temMulher = new VerificaSeHaMulher(pessoas).Verifica();
    }
}

class VerificaSeHaMulher {
    private readonly List<Pessoa> pessoas;
    public VerificaSeHaMulher(List<Pessoa> pessoas) => this.pessoas = pessoas;

    public bool Verifica() {
        foreach (var pessoa in pessoas) if (pessoa.Sexo == "F") return true;
        return false;
    }
}

class Pessoa {
    public string Nome;
    public string Sexo;
}

//https://pt.stackoverflow.com/q/92919/101
