using static System.Console;

public abstract class Pessoa {
    public abstract int Id { get; set; }
    public abstract string Nome { get; set; }

    public abstract void Andar();
}

public class Comprador : Pessoa {
    public override int Id { get; set; }  
    public override string Nome { get; set; }      

    public override void Andar() => WriteLine("Comprador andou");

    public void Comprar() => WriteLine("Comprou"); 
}

public class Vendedor : Pessoa {
    public override int Id { get; set; }
    public override string Nome { get; set; }

    public override void Andar() => WriteLine("Vendedor andou");

    public void Vender() => WriteLine("Vendeu");
}

public class Sistema {
	public static void Main() {
		var pessoaComprador = new Comprador();
		pessoaComprador.Nome = "João";
		pessoaComprador.Comprar();
		UmOutroMetodo(pessoaComprador);
		var pessoaVendedor = new Vendedor();
		pessoaVendedor.Nome = "José";
		pessoaVendedor.Vender();
		UmOutroMetodo(pessoaVendedor);
	}
	//note que se passar um objeto do tipo Pessoa nem funcionaria de fato, deve ser conreto
	public static void UmOutroMetodo(Pessoa pessoa) {
		WriteLine(pessoa.Nome); //vai pegar o que foi usado na classe concreta
		pessoa.Andar(); //vai lançar a exceção
	}
}

//https://pt.stackoverflow.com/q/154421/101
