using static System.Console;
using System.Collections.Generic;

List<Pessoa> pessoas = new() {{ new() }, { new PessoaFisica { Nome = "Rod" }}};
foreach (var pessoa in pessoas) WriteLine(pessoa.EuSou());
					
public class Pessoa { //não usei abstract para facilitar o exemplo
	protected int id; //campo
    public virtual string EuSou() => "Não sei quem sou!"; //método virtual
}

public class PessoaFisica : Pessoa {
	public string Nome { get; init; } //propriedade
    public override string EuSou() => $"Eu sou {Nome}!"; //método virtual sobrescrito
}
