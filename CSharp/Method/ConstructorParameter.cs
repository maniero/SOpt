using static System.Console;
using System.Collections.Generic;
					
public class Program {
	public static void Main() {
        var lista = CriarLista();
        var teste = new teste(lista);
        lista[0] = "Example";
        WriteLine(teste.testeVeridico());
		teste.OutroTeste(lista);
        WriteLine(teste.testeVeridico());
    }

    public static List<string> CriarLista() => new List<string>() { "A", "B", "C", "D", "E" };
}

public class teste {
    private List<string> Lista { get; set; }

    public teste(List<string> lista) => Lista = lista;

    public void OutroTeste(List<string> lista) {
		lista = new List<string>() { "aaa", "bbb" };
        return;
    }
    public bool testeVeridico() => Lista[0] == "Example"; //retorna true
}

//https://pt.stackoverflow.com/q/89955/101
