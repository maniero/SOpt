using static System.Console;
using System.Collections.Generic;
					
public class Program {
    public static void Main(string[] args) {
        var aluno = new List<Aluno> {
            new Aluno() { AlunoId = 1, Nome = "Cláudia",Email="claudia@email.com" },
            new Aluno() { AlunoId = 2, Nome = "Pedro",Email="pedro@email.com" },
            new Aluno() { AlunoId = 3, Nome = "Eduardo",Email="eduardo@email.com" }
        };
        WriteLine("==================================");
        foreach (var item in aluno) {
            WriteLine("ID: {0}\nNome: {1}\nEmail: {2}", item.AlunoId, item.Nome,item.Email);
            WriteLine("==================================");
        }
        aluno[0].Nome = "João";
        aluno[0].Email = "joao@email.com";
 		foreach (var item in aluno) {
            WriteLine("ID: {0}\nNome: {1}\nEmail: {2}", item.AlunoId, item.Nome,item.Email);
            WriteLine("==================================");
        }
    }
}

class Aluno {
    public int AlunoId { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }
}

//https://pt.stackoverflow.com/q/87295/101
