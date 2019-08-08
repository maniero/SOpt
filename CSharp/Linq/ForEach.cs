using static System.Console;
using System.Collections.Generic;

public class Program {
	public static void Main() {
		var lstPessoas = new List<Pessoas>();

		var pessoa = new Pessoas {
			Id = 1,
			Nome = "Mauricio" };
		lstPessoas.Add(pessoa);

		pessoa = new Pessoas {
			Id = 2,
			Nome = "João" };
		lstPessoas.Add(pessoa);

		pessoa = new Pessoas {
			Id = 3,
			Nome = "Maria" };
		lstPessoas.Add(pessoa);

		lstPessoas.ForEach(item => item.Nome = item.Id + " - " + item.Nome);
		foreach (var item in lstPessoas) {
			WriteLine(item.Nome);
		}
	}
}

public class Pessoas {
	public int Id { get; set; }
	public string Nome { get; set; }
}

//https://pt.stackoverflow.com/q/53106/101
