using static System.Console;
using System.Collections.Generic;

public class Program {
	public static void Main(string[] args) {
        var vizu = new Aluno() {
            Nome = "Joao Vizu",
            Ra = "N300361",
            NotaB1 = 7.5M,
            NotaB2 = 10M
        };
        var lais = new AlunoTecnologo() {
            Nome = "Lais Silva",
            Ra = "545454",
            NotaB1 = 7.5M,
            NotaB2 = 10M,
            NotaPim = 9M
        };
        var dao = new AlunoDao();
        dao.Adicionar(vizu);
        dao.Adicionar(lais);
        foreach (Aluno aluno in dao.Listar()) WriteLine($"Nome: {aluno.Nome}\tNotaB1: {aluno.NotaB1}\tNotaB2: {aluno.NotaB2}\tMedia: {aluno.Media}");
    }
}

public class Aluno {
    public string Nome { get; set; }
    public string Ra { get; set; }
    public decimal NotaB1 { get; set; }
    public decimal NotaB2 { get; set; }
    public virtual decimal Media => (NotaB1 + NotaB2) / 2;
}

 public class AlunoTecnologo : Aluno {
    public decimal NotaPim { get; set; }
    public override decimal Media => NotaPim * 0.2m + base.Media;
}

public class AlunoDao {
    private List<Aluno> alunos;
    public AlunoDao() => alunos = new List<Aluno>();
    public void Adicionar(Aluno aluno) => alunos.Add(aluno);
    public List<Aluno> Listar() => new List<Aluno>(alunos);
}

//https://pt.stackoverflow.com/q/404829/101
