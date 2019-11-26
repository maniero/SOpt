using static System.Console;
					
public class Program {
	public static void Main() {
		var pessoa = new Pessoa();
		var moto = new Moto(pessoa);
		var cliente = new Cliente(moto);
		cliente.ExibirDados();
		cliente.Moto.ExibirDados();
		cliente.Pessoa.ExibirDados();
	}
}

public class Pessoa {
	public string Nome { get; set; }
	public int Idade { get; set; }
	public Pessoa() {
		Write("Nome: ");
		Nome = ReadLine();
		Write("Idade: ");
		Idade = int.Parse(ReadLine());  //não é assim que faz, só pra simplificar
	}
	public void ExibirDados() => WriteLine($"Nome: {Nome}");
}

public class Cliente {
	public int Codigo { get; set; }
	public Pessoa Pessoa { get; set; }
	public Moto Moto { get; set; }
	public Cliente() {
		Write("Código do cliente: ");
		Codigo = int.Parse(ReadLine());
	}
	public Cliente(Pessoa pessoa) : this() => Pessoa = pessoa;
	public Cliente(Moto moto) : this(moto.Pessoa) => Moto = moto;
	public void ExibirDados() => WriteLine($"Código: {Codigo}");
}

public class Moto {
	public string Cor { get; set; }
	public Pessoa Pessoa { get; set; }
	public Moto() {
		Write("Cor: ");
		Cor = ReadLine();
	}
	public Moto(Pessoa pessoa) : this() => Pessoa = pessoa;
	public void ExibirDados() => WriteLine($"Cor: {Cor}");
}

//https://pt.stackoverflow.com/q/109591/101
