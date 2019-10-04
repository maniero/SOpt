using static System.Console;
using System.Collections.Generic;
using System.Linq;
					
public class Program {
    public static void Main(string[] args) {
        var alunos = new List<Aluno> {
            new Aluno() { AlunoId = 1, Nome = "Cláudia", Email = "claudia@email.com" },
            new Aluno() { AlunoId = 2, Nome = "Pedro",   Email = "pedro@email.com" },
            new Aluno() { AlunoId = 3, Nome = "Eduardo", Email = "eduardo@email.com" }
        };
		ImprimeAlunos(alunos);
		while (true) {
	        var id = 0;
			Write("Qual ID de aluno deseja modificar? (-1 para encerrar)");
			if (int.TryParse(ReadLine(), out id)) {
				if (id == -1) break;
				var alunoAchado = alunos.FirstOrDefault(x => x.AlunoId == id);
				if (alunoAchado != null) {
					Write("Qual o novo nome? ");
					alunoAchado.Nome = ReadLine();
					Write("Qual o novo e-mail? ");
        			alunoAchado.Email = ReadLine();
				} else WriteLine("Id inválido tente outro");
			} else WriteLine("Id inválido tente outro");
		}
         WriteLine("Nova Lista");
		ImprimeAlunos(alunos);
    }
	
	static void ImprimeAlunos(List<Aluno> alunos) {
        WriteLine("==================================");
		foreach (var item in alunos) {
            WriteLine($"ID: {item.AlunoId}\nNome: {item.Nome}\nEmail: {item.Email}");
            WriteLine("==================================");
        }
	}
}

class Aluno {
    public int AlunoId { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }
}

//https://pt.stackoverflow.com/q/87315/101
