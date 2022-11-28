public class Pessoa {
    public string Nome { get; set; } = "";
    public DateTime DataNascimento { get; set; }
    public Pessoa() {}
    public Pessoa(string nome, DateTime dtNasc) {
        Nome = nome;
        DataNascimento = dtNasc;
    }
}

public class Pessoa {
    public string Nome { get; set; };
    public DateTime DataNascimento { get; set; }
    public Pessoa() => Nome = "";
    public Pessoa(string nome, DateTime dtNasc) {
        Nome = nome;
        DataNascimento = dtNasc;
    }
}

public class Pessoa {
    public string Nome { get; required; };
    public DateTime DataNascimento { get; required; }
}

public class Pessoa {
    public string Nome { get; init; };
    public DateTime DataNascimento { get; init; }
}

Pessoa pessoa = PessoaController.Obter(id) ?? new() { Nome = "João", DataNascimento = DateTime(2000, 10, 10) };

public class Faculdade {
    public Pessoa Mantenedor { get; set; } = new Pessoa();
    public List<Aluno> Alunos { get; set;} = new List<Aluno>();
    public List<Disciplina> Disciplinas { get; set; } = new List<Disciplina>();
}

public class Aluno {
    public string Nome { get; set; }
    public int RM { get; set; }
    public bool Sexo { get; set; }          
}

//https://pt.stackoverflow.com/q/13922/101
