public class Program {
	public static void Main() {
		var usuario = new Usuario("João", "Rua da avenida, 123", "1234-5678");
		usuario.Telefone = "9876-5432";
		//No Winforms seria algo como
		//usuario.Telefone = Formulario.Telefone.Text
	}
}

public class Usuario {
    public string Nome {get; set;}
    public string Endereco {get; set;}
    public string Telefone {get; set;}

    public Usuario(string nome, string endereco, string telefone) {
        Nome = nome;
        Endereco = endereco;
        Telefone = telefone;
    }
}

//http://pt.stackoverflow.com/q/186973/101
