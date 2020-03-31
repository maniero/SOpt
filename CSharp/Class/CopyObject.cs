using static System.Console;
using System.Collections.Generic;
using System.Linq;

public class Program {
	public static void Main(string[] args) {
		var vaos = new List<Vao> {new Vao {Quantidade = 2, Medida = 2}, new Vao {Quantidade = 0, Medida = 0}, new Vao {Quantidade = 1, Medida = 1}};
		var ordenada = vaos.OrderBy(p => p.Medida).Select(item => item.Clone()).ToList();
		ordenada[1].Medida = 5;
		foreach (var item in ordenada) WriteLine($"{item.Quantidade} x {item.Medida}");
		foreach (var item in vaos) WriteLine($"{item.Quantidade} x {item.Medida}");
	}
}

public class Vao {
    public int Quantidade { get; set; }
    public double Medida { get; set; }
	public Vao Clone() => (Vao)this.MemberwiseClone();
}

//https://pt.stackoverflow.com/q/171836/101
