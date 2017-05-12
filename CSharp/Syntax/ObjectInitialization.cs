public class Program {
	public static void Main() {
		var joao = new Pessoa(1, "João da Silva", "@joao");
		var jose = new Pessoa(
		   pessoaId : 1,
		   nome : "José da Silva",
		   twitter : "@jose"
		);
		var joaquim = new Pessoa() {
		   PessoaId = 1,
		   Nome = "Joaquim da Silva",
		   Twitter = "@joaquim"
		};
	}
}

public class Pessoa {
	public Pessoa() {} //normalmente isto não é recomendado, fiz só para criar o terceiro exemplo
    public Pessoa(int pessoaId, string nome, string twitter) {
        PessoaId = pessoaId;
        Nome = nome;
        Twitter = twitter;
    }
    public int PessoaId { get; set; }
    public string  Nome { get; set; }
    public string Twitter { get; set; }
}

//https://pt.stackoverflow.com/q/34405/101
