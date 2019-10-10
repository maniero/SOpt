using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace ConsoleApplication10 {
    public class Program {
        public static void Main(string[] args) {
            List<Teste> lstTeste = new List<Teste> {
                new Teste {Codigo = 1, Quantidade = 10},
                new Teste {Codigo = 2, Quantidade = 10},
                new Teste {Codigo = 1, Quantidade = 10},
                new Teste {Codigo = 3, Quantidade = 10},
                new Teste {Codigo = 2, Quantidade = 10}
            };

			//Forma declarativa
			WriteLine("Forma declarativa");
		    var items =	from item in lstTeste
				group item by item.Codigo
				into g
				select new { Codigo = g.Key, Quantidade = g.Sum(item => item.Quantidade) };
			items.ToList().ForEach(item => { WriteLine($"Item: {item.Codigo} Quantidade: {item.Quantidade}"); });
			//forma imperativa
			WriteLine("Forma imperativa");
			var lista = lstTeste.GroupBy(g => g.Codigo).Select(g => new {
				Codigo = g.First().Codigo, Quantidade = g.Sum(h => h.Quantidade) });
			lista.ToList().ForEach(item => { WriteLine($"Item: {item.Codigo} Quantidade: {item.Quantidade}"); });
			//forma com dicionário - Sem LINQ
			WriteLine("Forma com dicionário");
			var dicionario = new Dictionary<int, Teste>();
			foreach (var item in lstTeste) {
				if (dicionario.ContainsKey(item.Codigo)) dicionario[item.Codigo].Quantidade += item.Quantidade;
				else dicionario[item.Codigo] = item;
            }
 			foreach (var item in dicionario.Values) WriteLine($"Item: {item.Codigo} Quantidade: {item.Quantidade}");
       }
    }

    public class Teste {
        public int Codigo { get; set; }
        public int Quantidade { get; set; }
    }
}

//https://pt.stackoverflow.com/q/88384/101
