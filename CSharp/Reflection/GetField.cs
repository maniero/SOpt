using static System.Console;

public class Program {
	public static void Main() {
		var obj = new Usuario();
		obj.nome = "João";
		WriteLine(obj.GetType().GetField("nome").GetValue(obj).ToString());
	}
}

public class Usuario {
    public string nome;
    public string cpf;
    public string senha;
}

//https://pt.stackoverflow.com/q/343598/101
