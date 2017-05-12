using static System.Console;

public class Program {
	public static void Main() {
		var objeto = new Classe(1);
		WriteLine(objeto.IsFree);
	}
}

public class Classe {
	public Classe(int x) => status = x;
    private int status; //aqui ocupa 4 bytes
    public bool IsFree { get => status > 0; } //aqui nada ocupa na instância
	public int Id { get; } = 0; //aqui ocupará 4 bytes porque tem um campo implícito
}

//https://pt.stackoverflow.com/q/203908/101
