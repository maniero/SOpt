using static System.Console;
using System.Linq;

public class C {
    public static void Main() {
		var vec1 = new Paragem[3] {
				new Paragem(1, "Nome1", "Porto"),
        		new Paragem(2, "Nome2", "Maia"),
				new Paragem(3, "Nome3", "Matosinhos") };
		WriteLine($"Primeiro {vec1.First().Nome} - Ultimo {vec1.Last().Nome}");
    }
}
public class Paragem {
	public Paragem(int id, string nome, string nome2) {
		Id = id;
		Nome = nome;
		Nome2 = nome2;
	}
		
	public int Id { get; set; }
	public string Nome { get; set; }
	public string Nome2 { get; set; }
}

//http://pt.stackoverflow.com/q/188170/101
