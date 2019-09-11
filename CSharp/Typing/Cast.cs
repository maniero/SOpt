public class Program {
	public static void Main() {
		ITeste<Objeto> teste = new CarroTeste();
	}
}

public class Objeto {
    protected string _nome;
    public string nome => _nome;
}

public class Carro : Objeto {
    public Carro() => _nome = "Carro";
}

public interface ITeste<out T> where T : Objeto {
    string GetNome();
}

public abstract class TesteBase<T> : ITeste<T> where T : Objeto {
    protected Objeto _obj = null;
    public abstract string GetNome();
}

public class CarroTeste : TesteBase<Carro> {
    public override string GetNome() => "Meu nome é : " + _obj.nome;
}

//https://pt.stackoverflow.com/q/75097/101
