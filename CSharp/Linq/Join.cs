using static System.Console;
using System.Linq;
using System.Collections.Generic;

class Customer {
    public int ID { get; set; }
    public string Name { get; set; }
}

class Order {
    public int ID { get; set; }
    public string Product { get; set; }
}

public static class Program {
    public static void Main() {
		// Example customers.
		var customers = new Customer[] {
			new Customer{ID = 5, Name = "Sam"},
			new Customer{ID = 6, Name = "Dave"},
			new Customer{ID = 7, Name = "Julia"},
			new Customer{ID = 8, Name = "Sue"}
		};
	
		// Example orders.
		var orders = new Order[] {
			new Order{ID = 5, Product = "Book"},
			new Order{ID = 6, Product = "Game"},
			new Order{ID = 7, Product = "Computer"},
			new Order{ID = 8, Product = "Shirt"}
		};
	
		// Join on the ID properties.
		var query = from c in customers
				join o in orders on c.ID equals o.ID
				select new { c.Name, o.Product };

		WriteLine(query.GetType());

		// Display joined groups.
		foreach (var group in query) {
			WriteLine("{0} bought {1}", group.Name, group.Product);
		}
		var lista = query.ToList();
		WriteLine(lista.GetType());
		
		//criando explicitamente uma lista de string (neste caso é possível)
		var query2 = from c in customers
				join o in orders on c.ID equals o.ID
				select new List<string> { c.Name, o.Product };

		WriteLine(query2.GetType());


		foreach (var group in query2) {
			WriteLine("{0} bought {1}", group[0], group[1]);
		}
		var lista2 = query2.ToList();
		WriteLine(lista2.GetType());
	}
}

//https://pt.stackoverflow.com/q/48172/101
