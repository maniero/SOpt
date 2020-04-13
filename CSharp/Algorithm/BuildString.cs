using static System.Console;
using System.Collections.Generic;
using System.Text;

public class Program {
	public static void Main() {
		var pessoa = new Pessoa() { Nome = "Jão" };
		pessoa.Enderecos = new List<Endereco> {
            new Endereco() { Cidade = "São Paulo", Estado = "SP", Pessoa = pessoa },
            new Endereco() { Cidade = "Rio de Janeiro", Estado = "RJ", Pessoa = pessoa },
            new Endereco() { Cidade = "Belo Horizonte", Estado = "MG", Pessoa = pessoa }
		};
        var result = new StringBuilder(pessoa.Enderecos.Count * 36);
        foreach (var item in pessoa.Enderecos) result.Append(item.Cidade + " | " + item.Estado + " | ");
        WriteLine($"Endereços: {result}");
        result.Clear();
		pessoa.Enderecos.ForEach(item => result.Append(item.Cidade + " | " + item.Estado + " | "));
        WriteLine($"Endereços: {result}");
	}
}

public class Pessoa {
	public string Nome;
	public List<Endereco> Enderecos;
}
	
public class Endereco {
	public string Cidade;
	public string Estado;
	public Pessoa Pessoa;
}

//https://pt.stackoverflow.com/q/445505/101
