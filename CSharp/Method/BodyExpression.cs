using static System.Console;
using System;

public class Program {
	public static void Main() {
		var objeto = new Exemplo(42);
		objeto.Imprime();
		WriteLine(objeto. Executa());
		WriteLine(objeto.Executa2());
		objeto.Prop = 42;
		WriteLine(objeto.Prop);
		objeto.Prop = 12;
	}
}

public class Exemplo {
	private int prop;
	public int Prop { get => prop; set => prop = value == 42 ? value : throw new ArgumentException("Tem que ser 42 ", nameof(Prop)); }
	
	public Exemplo(int x) => prop = x;
	
	public void Imprime() => WriteLine("ok");
	public string Executa() => "texto";
	//public bool Teste2() => WriteLine("ok2"); return true; //daria erro
	public string Executa2() { //é a mesma coisa
		return "texto";
	}
}

//https://pt.stackoverflow.com/q/206998/101
