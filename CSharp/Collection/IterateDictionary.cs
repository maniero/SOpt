using static System.Console;
using System.Collections.Generic;
using System.Linq;

public class Program {
	public static void Main() {
		var dicionario = new Dictionary<string, int> { ["joão"] = 15, ["josé"] = 20, ["joaquim"] = 25 };
		WriteLine("foreach par");
		foreach (var par in dicionario) WriteLine($"{par.Key} => {par.Value}");
		WriteLine("---------------------");
		WriteLine("foreach key");
		foreach (var key in dicionario.Keys) WriteLine($"{key} => {dicionario[key]}");
		WriteLine("---------------------");
		WriteLine("foreach value");
		foreach (var value in dicionario.Values) WriteLine($"{value}");
		WriteLine("---------------------");
		WriteLine("for index");
		for (var i = 0; i < dicionario.Count; i++) {
			var par = dicionario.ElementAt(i);
			WriteLine($"{par.Key} => {par.Value}");
		}
		WriteLine("---------------------");
		WriteLine("for iterator");
		for (var iterador = dicionario.GetEnumerator(); iterador.MoveNext();) {
			var par = iterador.Current;
			WriteLine($"{par.Key} => {par.Value}");
		}
		WriteLine("---------------------");
		WriteLine("while iterator");
		using (var iterador = dicionario.GetEnumerator()) {
			while (iterador.MoveNext()) {
				var par = iterador.Current;
				WriteLine($"{par.Key} => {par.Value}");
			}
		}
		WriteLine("---------------------");
		WriteLine("método abstrato");
		foreach (var valor in Iterar(dicionario)) WriteLine($"{valor}"); //só para consumir
		WriteLine("---------------------");
		WriteLine("LINQ ForEach");
		dicionario.Keys.ToList().ForEach(key => WriteLine($"{key} => {dicionario[key]}"));
		WriteLine("---------------------");
		WriteLine("LINQ OrderBy+Select");
		foreach (var par in dicionario.OrderBy(par => par.Key).Where(par => par.Value >= 18)) {
			WriteLine($"{par.Key} => {par.Value}"); //foreach só para consumir e mostrar
			WriteLine("---------------------");
			WriteLine("Parallel LINQ");
			dicionario.AsParallel().ForAll(par => { WriteLine($"{par.Key} => {par.Value}"); });
			WriteLine("---------------------");
			WriteLine("Parallel LINQ de novo - pode dar ordem diferente");
			dicionario.AsParallel().ForAll(par => { WriteLine($"{par.Key} => {par.Value}"); });
		}
		static IEnumerable<int> Iterar(Dictionary<string, int> dicionario) {
			foreach (var par in dicionario) yield return par.Value;
		}
	}
}

//https://pt.stackoverflow.com/q/158220/101
