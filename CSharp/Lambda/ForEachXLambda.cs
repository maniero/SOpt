using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
					
public class Program {
	public static void Main() {
		var lista = new List<Classe>();
		for (int i = 0; i < 66000; i++) {
			lista.Add(new Classe() { Campo = "teste" + i.ToString() });
		}
		lista.Add(new Classe() { Campo = "MeuNome" });
		var relogio = new Stopwatch();
		relogio.Start();
		var teste = "";
		for (int i = 0; i < lista.Count; i++) {
			if (lista[i].Campo == "MeuNome") {
				teste = lista[i].Campo;
				break;
			}
		}
		relogio.Stop();
		WriteLine("Resultado do for: {0}", teste);
		WriteLine(relogio.ElapsedTicks);
		relogio.Restart();
		teste = "";
		foreach (var i in lista) {
			if (i.Campo == "MeuNome") {
				teste = i.Campo;
				break;
			}
		}
		relogio.Stop();
		WriteLine("Resultado do foreach: {0}", teste);
		WriteLine(relogio.ElapsedTicks);
		relogio.Restart();
		teste = "";
        teste = lista.Select(campo => campo.Campo).FirstOrDefault(c => c == "MeuNome");
		relogio.Stop();
		WriteLine("Resultado do LINQ: {0}", teste);
		WriteLine(relogio.ElapsedTicks);
		lista.Insert(0, new Classe() { Campo = "MeuNome" });
		WriteLine("Agora acha no primeiro");
		relogio.Restart();
		teste = "";
		for (int i = 0; i < lista.Count; i++) {
			if (lista[i].Campo == "MeuNome") {
				teste = lista[i].Campo;
				break;
			}
		}
		relogio.Stop();
		WriteLine("Resultado do for: {0}", teste);
		WriteLine(relogio.ElapsedTicks);
		relogio.Restart();
		teste = "";
		foreach (var i in lista) {
			if (i.Campo == "MeuNome") {
				teste = i.Campo;
				break;
			}
		}
		relogio.Stop();
		WriteLine("Resultado do foreach: {0}", teste);
		WriteLine(relogio.ElapsedTicks);
		relogio.Restart();
		teste = "";
        teste = lista.Select(campo => campo.Campo).FirstOrDefault(c => c == "MeuNome");
		relogio.Stop();
		WriteLine("Resultado do LINQ: {0}", teste);
		WriteLine(relogio.ElapsedTicks);
		relogio.Restart();
	}
}

public class Classe {
	public string Campo;
}

//https://pt.stackoverflow.com/q/53850/101
