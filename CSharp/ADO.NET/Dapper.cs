public class Teste {
    public int Id { get; set; }
    public string Nome { get; set; }
    public int Idade { get; set; }
}

var newTeste = db.Execute("Insert Into Teste (nome, idade) Values(@Nome, @Idade)", t);

//https://pt.stackoverflow.com/q/242559/101
