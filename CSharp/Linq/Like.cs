using static System.Console;
using System.Collections.Generic;
using System.Linq;
					
public class Program {
	public static void Main() {		
		var pessoas = new List<Pessoa>() {
			new Pessoa() { Nome = "Maria José" },
			new Pessoa() { Nome= "José Maria"}, 
			new Pessoa() { Nome= "José Maria José"} 
		};
		WriteLine("Início");
        foreach (var pessoa in pessoas.Where(p => p.Nome.StartsWith("Maria")).OrderBy(p => p.Nome)) WriteLine(pessoa.Nome);
		WriteLine();
		WriteLine("Fim");
        foreach (var pessoa in pessoas.Where(p => p.Nome.EndsWith("Maria")).OrderBy(p => p.Nome)) WriteLine(pessoa.Nome);
		WriteLine();
		WriteLine("Qualquer lugar");
        foreach (var pessoa in pessoas.Where(p => p.Nome.Contains("Maria")).OrderBy(p => p.Nome)) WriteLine(pessoa.Nome);
	}
}

public class Pessoa {
	public string Nome;
}

//https://pt.stackoverflow.com/q/91933/101
