using System;
using static System.Console;
					
public class Program {
	public static void Main() {
		var teste = new Teste(1, "abc");
		WriteLine(teste.a);
		WriteLine(teste.c);
		var teste2 = new Teste();
		WriteLine(teste2.a);
		WriteLine(teste2.c);
		var teste3 = new Teste(15) { a = 2, c = "xxx".ToCharArray() };
		WriteLine(teste3.a);
		WriteLine(teste3.c);
		var teste4 = new Teste(1, "abc123456789012345678901234567890");
	}
}

struct Teste {
	public int a;
	public char[] c;
	public Teste(int size = 30) {
		if (size > 30) throw new ArgumentException($"parâmetro deve ter tamanho máximo de 30");
		a = 0;
		c = new char[size];
	}
	public Teste(int a, char[] c) {
		if (c.Length > 30) throw new ArgumentException($"parâmetro para {nameof(c)} deve ter tamanho máximo de 30");
		this.a = a;
		this.c = c;
	}
	public Teste(int a, string c) : this(a, c.ToCharArray()) {}
}

//https://pt.stackoverflow.com/q/106470/101
