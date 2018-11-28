using System;
using static System.Console;
using System.Linq;

public class Program {
	public static void Main() {
		var lista = (from arquivo in AppDomain.CurrentDomain.GetAssemblies()
                   from tipo in arquivo.GetTypes()
                   where typeof(Type).IsAssignableFrom(tipo)
                   select tipo).ToArray();
		foreach (var arquivo in lista) WriteLine(arquivo);
	}
}

//https://pt.stackoverflow.com/q/42910/101
