using System.Collections.Generic;
using static System.Console;
					
public class Program {
    public static void Main() {
		WriteLine("Dicionário de String");
		var dict = new Dictionary<string, string> {["nome"] = "Pedro", ["Idade"] = "18"};
        foreach (var item in dict) WriteLine($"{item.Key} => {item.Value}");
		WriteLine("Dicionário de Object");
		var dict2 = new Dictionary<string, object> {["nome"] = "Pedro", ["Idade"] = 18};
        foreach (var item in dict2) WriteLine($"{item.Key} => {item.Value}");
		WriteLine("Array multidemensional - Todos itens");
        var array = new string[,] {
           {"nome0", "idade1"},
           {"nome1", "idade2"}
        };
        foreach (var item in array) WriteLine($"{item}");
		WriteLine("Array multidemensional - Cada dimensão");
        for (var i = 0; i < array.GetLength(0); i++) {
	        for (var j = 0; j < array.GetLength(1); j++) WriteLine($"{array[i, j]}");
        }
		WriteLine("Jagged Array multidemensional");
		var jaggedArray = new string[2][] {new string[2] {"nome0", "idade1"}, new string[2] {"nome1", "idade2"}};
		foreach (var subArray in jaggedArray) {
			foreach (var item in subArray) WriteLine($"{item}");
		}
		WriteLine("Classe");
		var listaPessoas = new List<Pessoa> {
			new Pessoa {Nome = "Pedro", Idade = 18},
			new Pessoa {Nome = "João", Idade = 15}
		};
        foreach (var item in listaPessoas) WriteLine($"{item.Nome} => {item.Idade}");
	}
}
public class Pessoa {
	public string Nome { get; set; }
	public int Idade { get; set; }
}

//https://pt.stackoverflow.com/q/148114/101
