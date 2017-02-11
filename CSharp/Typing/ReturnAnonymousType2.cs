using static System.Console;
using System.Collections.Generic;
using System.Linq;

public class Program {
    public static void Main() {
        var lista = ListarAnonimo();
		foreach (var item in lista) {
			var pessoa = Util.Cast(item, new { Nome = "", Idade = 0, Salario = 0.0m });
			WriteLine($"Nome: {pessoa.Nome} - Idade: {pessoa.Idade} - Salario {pessoa.Salario}");
		}
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

public static class Util {
    public static T Cast<T>(object obj, T type) {
        return (T)obj;
    }
}

//http://pt.stackoverflow.com/q/183594/101
