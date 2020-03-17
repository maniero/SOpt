using System.Collections.Generic;
using static System.Console;
using System;
					
public class Program {
	public static void Main() {
		MvcHtmlString(new List<Funcionario> { new Funcionario() });
		MvcHtmlString(new List<Carro> { new Carro() });
	}
	public static void MvcHtmlString<T>(List<T> listaObj) {
		if (typeof(T) == typeof(Funcionario)) WriteLine("É lista de Funcionários");
		else WriteLine("Não é lista de Funcionários");
	}
}

public class Funcionario{
    public long Id {get; set;}
    public string Nome {get; set;}
    public DateTime DataContrato {get; set;}
}

public class Carro{
    public long Id {get; set;}
    public string Nome {get; set;}
    public bool IsUsado {get; set;}
}

//https://pt.stackoverflow.com/q/161578/101
