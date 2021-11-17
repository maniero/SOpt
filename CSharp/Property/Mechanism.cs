using System;

public class Program {
	public static void Main() {
		var obj = new MinhaClasse();
		obj.Idade = 20;
		Console.WriteLine(obj.Idade);
		obj.Idade = 10;
		
	}
}

public class MinhaClasse {
	private int idade;
    public int Idade {
        get => idade;
        set => idade = value < 18 ? throw new Exception("Proibido para menores!") : value;
    }
}

//https://pt.stackoverflow.com/q/263498/101
