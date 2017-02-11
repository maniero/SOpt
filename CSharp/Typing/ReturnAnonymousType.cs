using System.Collections.Generic;
using System.Linq;
					
public class Program {
	public static void Main() {
		var lista = ListarAnonimo();
	}
		public static List<object> ListarAnonimo() {
		var lista = new object[] {
			new {
				Nome = "",
				Idade = 0,
				Salario = 0.0m
			}
		}.ToList();
		lista.Clear();
		lista.Add(new {
			Nome = "Gato",
			Idade = 25,
			Salario = 3000000.0m
		});
		return lista;
	}
}

//http://pt.stackoverflow.com/q/183594/101
