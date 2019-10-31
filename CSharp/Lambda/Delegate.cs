using System;
using static System.Console;

public class Program {
	public static void Main() {
	    var x = new Exemplo();
    	x.handler("http://dominio.br/pagina.html");
	    x.handler = Write;
	    x.handler("http://dominio.br/pagina.html");
		Write("Fim");
	}
    class Exemplo {
         public Action<string> handler = WriteLine;
    }
}

//https://pt.stackoverflow.com/q/101238/101
