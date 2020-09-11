using System;

public class Program {
	public static void Main() {
		foreach (var arquivo in AppDomain.CurrentDomain.GetAssemblies()) {
			foreach (var tipo in arquivo.GetTypes()) {
				if (typeof(Type).IsAssignableFrom(tipo)) {
		            Console.WriteLine(tipo);
				}
			}
		}
	}
}

//https://pt.stackoverflow.com/q/42910/101
