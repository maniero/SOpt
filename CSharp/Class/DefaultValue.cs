using static System.Console;
#nullable enable
			
public class Program {
	public static void Main() {
		Carro carro = default;
		WriteLine(carro.Marca);
		Carro? carro2 = default;
		WriteLine(carro2.Marca);
		Carro carro3 = new Carro();
		WriteLine(carro3.Marca);
	}
}

public class Carro {
	public string Marca;
	public string Modelo = "";
	public string? Tipo;
}

//https://pt.stackoverflow.com/q/430014/101
