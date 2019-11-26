using static System.Console;
					
public class Program {
	public static void Main() => new Cliente().Add();
}

public class Pessoa {
	public string Nome { get; set; }
	public int Idade { get; set; }
	public virtual void Add() {
		Nome = ReadLine();
		Idade = int.Parse(ReadLine()); //não é assim que faz, só pra simplificar
	}
}

public class Cliente : Pessoa {
	public int Codigo { get; set; }
	public override void Add() {
		base.Add();
		Codigo = int.Parse(ReadLine());
		var moto = new Moto();
		moto.AddMoto();
		moto.ExibirDados();
		ExibirDados();
	}
	public void ExibirDados() => WriteLine("Titular: " + Nome);
}

public class Moto {
	public string Cor { get; set; }
	public void AddMoto() => Cor = ReadLine();
	public void ExibirDados() => WriteLine("Cor: " + Cor);
}

//https://pt.stackoverflow.com/q/109591/101
