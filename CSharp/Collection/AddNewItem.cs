using static System.Console;
using System.Collections.Generic;

public class Program {
    public static void Main(string[] args) {
		var list = new List<Item>() {
			new Item() { Nome = "GPU" },
            new Item() { Nome = "Livro" }
		};
        list.Add(new Item() { Nome = "Cadeira" });
		var item = new Item() { Nome = "Abóbora" };
		list.Add(item);
		var carro = new Item() { Nome = "Carro" };
		list.Add(carro);
		item = new Item() { Nome = "Outro objeto" };
		list.Add(item);
		list.Add(carro);
        for (int i = 0; i < list.Count; i++) {
			WriteLine($"Item: {list[i].Nome}");
        }
    }
}

public class Item {
	public string Nome;
}

//https://pt.stackoverflow.com/q/244617/101
